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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.cboTag = this.Factory.CreateRibbonComboBox();
            this.btnInsertText = this.Factory.CreateRibbonButton();
            this.btnAddTagList = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.cboTag);
            this.group1.Items.Add(this.btnInsertText);
            this.group1.Items.Add(this.btnAddTagList);
            this.group1.Label = "Gán thẻ dữ liệu";
            this.group1.Name = "group1";
            // 
            // cboTag
            // 
            ribbonDropDownItemImpl1.Label = "A Ă Á";
            ribbonDropDownItemImpl2.Label = "B Ba Bì";
            this.cboTag.Items.Add(ribbonDropDownItemImpl1);
            this.cboTag.Items.Add(ribbonDropDownItemImpl2);
            this.cboTag.Label = "Thẻ";
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
            // btnAddTagList
            // 
            this.btnAddTagList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTagList.Image")));
            this.btnAddTagList.Label = "Thêm thẻ";
            this.btnAddTagList.Name = "btnAddTagList";
            this.btnAddTagList.ShowImage = true;
            this.btnAddTagList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddTagList_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox cboTag;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddTagList;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
