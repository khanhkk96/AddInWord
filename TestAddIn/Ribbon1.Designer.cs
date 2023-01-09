namespace TestAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box6 = this.Factory.CreateRibbonBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.btnAddTagList = this.Factory.CreateRibbonButton();
            this.box4 = this.Factory.CreateRibbonBox();
            this.cboTag = this.Factory.CreateRibbonComboBox();
            this.btnInsertText = this.Factory.CreateRibbonButton();
            this.box1 = this.Factory.CreateRibbonBox();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box5 = this.Factory.CreateRibbonBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.btnAddBarcode = this.Factory.CreateRibbonButton();
            this.box3 = this.Factory.CreateRibbonBox();
            this.label3 = this.Factory.CreateRibbonLabel();
            this.btnSetupPage = this.Factory.CreateRibbonButton();
            this.box2 = this.Factory.CreateRibbonBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box6.SuspendLayout();
            this.box4.SuspendLayout();
            this.group2.SuspendLayout();
            this.box5.SuspendLayout();
            this.box3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box6);
            this.group1.Items.Add(this.box4);
            this.group1.Items.Add(this.box1);
            this.group1.Label = "Thẻ gán dữ liệu";
            this.group1.Name = "group1";
            // 
            // box6
            // 
            this.box6.Items.Add(this.label1);
            this.box6.Items.Add(this.btnAddTagList);
            this.box6.Name = "box6";
            // 
            // label1
            // 
            this.label1.Label = "B1-Thêm thẻ dữ liệu từ excel:";
            this.label1.Name = "label1";
            // 
            // btnAddTagList
            // 
            this.btnAddTagList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTagList.Image")));
            this.btnAddTagList.Label = "Chọn file";
            this.btnAddTagList.Name = "btnAddTagList";
            this.btnAddTagList.ShowImage = true;
            this.btnAddTagList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddTagList_Click);
            // 
            // box4
            // 
            this.box4.Items.Add(this.cboTag);
            this.box4.Items.Add(this.btnInsertText);
            this.box4.Name = "box4";
            // 
            // cboTag
            // 
            ribbonDropDownItemImpl1.Label = "--Thêm thẻ dữ liệu--";
            this.cboTag.Items.Add(ribbonDropDownItemImpl1);
            this.cboTag.Items.Add(ribbonDropDownItemImpl2);
            this.cboTag.Label = "B2-Chọn thẻ:";
            this.cboTag.Name = "cboTag";
            this.cboTag.Text = null;
            // 
            // btnInsertText
            // 
            this.btnInsertText.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertText.Image")));
            this.btnInsertText.Label = "Chèn thẻ";
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.ShowImage = true;
            this.btnInsertText.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertText_Click);
            // 
            // box1
            // 
            this.box1.Name = "box1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.box5);
            this.group2.Items.Add(this.box3);
            this.group2.Items.Add(this.box2);
            this.group2.Label = "Setup trang";
            this.group2.Name = "group2";
            // 
            // box5
            // 
            this.box5.Items.Add(this.label2);
            this.box5.Items.Add(this.btnAddBarcode);
            this.box5.Name = "box5";
            // 
            // label2
            // 
            this.label2.Label = "B3-Barcode:";
            this.label2.Name = "label2";
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBarcode.Image")));
            this.btnAddBarcode.Label = "Thêm";
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.ShowImage = true;
            this.btnAddBarcode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddBarcode_Click);
            // 
            // box3
            // 
            this.box3.Items.Add(this.label3);
            this.box3.Items.Add(this.btnSetupPage);
            this.box3.Name = "box3";
            // 
            // label3
            // 
            this.label3.Label = "B4-Setup trang:";
            this.label3.Name = "label3";
            // 
            // btnSetupPage
            // 
            this.btnSetupPage.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupPage.Image")));
            this.btnSetupPage.Label = "Setup";
            this.btnSetupPage.Name = "btnSetupPage";
            this.btnSetupPage.ShowImage = true;
            this.btnSetupPage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetupPage_Click);
            // 
            // box2
            // 
            this.box2.Name = "box2";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box6.ResumeLayout(false);
            this.box6.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox cboTag;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddTagList;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label3;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddBarcode;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetupPage;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box6;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
