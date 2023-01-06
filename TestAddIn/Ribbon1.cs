using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace TestAddIn
{
    public partial class Ribbon1
    {


        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        public string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
                //else
                //{
                //    sb.Append("_");
                //}
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        private void btnInsertText_Click(object sender, RibbonControlEventArgs e)
        {
            var Application = Globals.ThisAddIn.Application;
            int start = Application.Selection.Range.Start;
            int end = Application.Selection.Range.End;
            Word.Range rng = Application.ActiveDocument.Range(start, end);
            rng.Select();
            string selectedTag = cboTag.Text;
            if (selectedTag != "")
            {
                string value = selectedTag.Replace("*", "").Trim().Replace(" ", "_");
                rng.Text = $"{{{convertToUnSign2(value).ToLower()}}}";
                return;
            }
            rng.Text = "";
        }

        private void btnAddTagList_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.xls|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cboTag.Items.Clear();
                string filePath = dialog.FileName;

                Excel.Application xlApp = null;
                Excel.Workbook xlWorkbook = null;
                Excel._Worksheet xlWorksheet = null;
                Excel.Range xlRange = null;
                try
                {
                    xlApp = new Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(filePath);
                    xlWorksheet = xlWorkbook.Sheets[1];
                    xlRange = xlWorksheet.UsedRange;
                    for (int j = 1; j <= xlRange.Columns.Count; j++)
                    {
                        RibbonDropDownItem item = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                        item.Label = xlRange.Cells[1, j].Value2.ToString();
                        cboTag.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //release com objects to fully kill excel process from running in the background
                    if (xlRange != null)
                    {
                        Marshal.ReleaseComObject(xlRange);
                    }
                    if (xlWorksheet != null)
                    {
                        Marshal.ReleaseComObject(xlWorksheet);
                    }

                    //close and release
                    if (xlWorkbook != null)
                    {
                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);
                    }

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }


        }

        private void btnAddBarcode_Click(object sender, RibbonControlEventArgs e)
        {
            var Application = Globals.ThisAddIn.Application;
            int start = Application.Selection.Range.Start;
            int end = Application.Selection.Range.End;
            Word.Range rng = Application.ActiveDocument.Range(start, end);
            rng.Select();
            rng.Text = "{%barcode_image}";
        }

        private void btnSetupPage_Click(object sender, RibbonControlEventArgs e)
        {
            var Application = Globals.ThisAddIn.Application;
            int start = 0;
            int end = 0;
            Word.Range rng = Application.ActiveDocument.Range(start, end);
            rng.Select();
            rng.Text = "{#data}";

            int startEndLine = Application.ActiveDocument.Paragraphs.Last.Range.Start;
            int endEndLine = Application.ActiveDocument.Paragraphs.Last.Range.Start;
            Word.Range rngEndLine = Application.ActiveDocument.Range(startEndLine, endEndLine);
            rngEndLine.Select();
            rngEndLine.Text = "{@raw_loop_pagebreak}\n{/}";
        }
    }
}
