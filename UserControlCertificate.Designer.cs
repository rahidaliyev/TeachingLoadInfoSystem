namespace TeachingLoadInfoSystem
{
    partial class UserControlCertificate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCertificate));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.subjectCmb = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.countryTxt = new DevExpress.XtraEditors.TextEdit();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.isLocalCheck = new DevExpress.XtraEditors.CheckEdit();
            this.certificateNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isLocalCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.subjectCmb);
            this.layoutControl1.Controls.Add(this.countryTxt);
            this.layoutControl1.Controls.Add(this.deleteBtn);
            this.layoutControl1.Controls.Add(this.isLocalCheck);
            this.layoutControl1.Controls.Add(this.certificateNameTxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(548, 104);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // subjectCmb
            // 
            this.subjectCmb.Location = new System.Drawing.Point(96, 38);
            this.subjectCmb.Name = "subjectCmb";
            this.subjectCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.subjectCmb.Properties.DisplayMember = "SubjectName";
            this.subjectCmb.Properties.NullText = "";
            this.subjectCmb.Properties.PopupView = this.searchLookUpEdit1View;
            this.subjectCmb.Properties.ValueMember = "ID";
            this.subjectCmb.Size = new System.Drawing.Size(320, 22);
            this.subjectCmb.StyleController = this.layoutControl1;
            this.subjectCmb.TabIndex = 5;
            this.subjectCmb.EditValueChanged += new System.EventHandler(this.subjectCmb_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(96, 64);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(320, 22);
            this.countryTxt.StyleController = this.layoutControl1;
            this.countryTxt.TabIndex = 4;
            this.countryTxt.EditValueChanged += new System.EventHandler(this.countryTxt_EditValueChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(501, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBtn.Size = new System.Drawing.Size(35, 27);
            this.deleteBtn.StyleController = this.layoutControl1;
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // isLocalCheck
            // 
            this.isLocalCheck.Location = new System.Drawing.Point(420, 12);
            this.isLocalCheck.Name = "isLocalCheck";
            this.isLocalCheck.Properties.Caption = "Yerli";
            this.isLocalCheck.Size = new System.Drawing.Size(77, 24);
            this.isLocalCheck.StyleController = this.layoutControl1;
            this.isLocalCheck.TabIndex = 2;
            this.isLocalCheck.CheckedChanged += new System.EventHandler(this.isLocalCheck_CheckedChanged);
            // 
            // certificateNameTxt
            // 
            this.certificateNameTxt.Location = new System.Drawing.Point(96, 12);
            this.certificateNameTxt.Name = "certificateNameTxt";
            this.certificateNameTxt.Size = new System.Drawing.Size(320, 22);
            this.certificateNameTxt.StyleController = this.layoutControl1;
            this.certificateNameTxt.TabIndex = 0;
            this.certificateNameTxt.EditValueChanged += new System.EventHandler(this.bookNameTxt_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(548, 104);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.certificateNameTxt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(408, 26);
            this.layoutControlItem1.Text = "Sertifikat adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.isLocalCheck;
            this.layoutControlItem2.Location = new System.Drawing.Point(408, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(81, 84);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deleteBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(489, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(39, 84);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.countryTxt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(408, 32);
            this.layoutControlItem4.Text = "Təşkilat";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.subjectCmb;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(408, 26);
            this.layoutControlItem5.Text = "Fənn";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 16);
            // 
            // UserControlCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserControlCertificate";
            this.Size = new System.Drawing.Size(548, 104);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isLocalCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit isLocalCheck;
        private DevExpress.XtraEditors.TextEdit certificateNameTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit countryTxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SearchLookUpEdit subjectCmb;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
