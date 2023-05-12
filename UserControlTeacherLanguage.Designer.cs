namespace TeachingLoadInfoSystem
{
    partial class UserControlTeacherLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTeacherLanguage));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.preferenceTxt = new DevExpress.XtraEditors.SpinEdit();
            this.languageCmb = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.preferenceLbl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferenceTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenceLbl)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.preferenceTxt);
            this.layoutControl1.Controls.Add(this.languageCmb);
            this.layoutControl1.Controls.Add(this.deleteBtn);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(470, 53);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // preferenceTxt
            // 
            this.preferenceTxt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.preferenceTxt.Location = new System.Drawing.Point(360, 12);
            this.preferenceTxt.Name = "preferenceTxt";
            this.preferenceTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.preferenceTxt.Properties.MaskSettings.Set("mask", "d");
            this.preferenceTxt.Size = new System.Drawing.Size(70, 24);
            this.preferenceTxt.StyleController = this.layoutControl1;
            this.preferenceTxt.TabIndex = 6;
            this.preferenceTxt.EditValueChanged += new System.EventHandler(this.preferenceTxt_EditValueChanged);
            // 
            // languageCmb
            // 
            this.languageCmb.Location = new System.Drawing.Point(83, 12);
            this.languageCmb.Name = "languageCmb";
            this.languageCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.languageCmb.Properties.DisplayMember = "LanguageName";
            this.languageCmb.Properties.NullText = "";
            this.languageCmb.Properties.PopupView = this.searchLookUpEdit1View;
            this.languageCmb.Properties.ValueMember = "ID";
            this.languageCmb.Size = new System.Drawing.Size(202, 22);
            this.languageCmb.StyleController = this.layoutControl1;
            this.languageCmb.TabIndex = 5;
            this.languageCmb.EditValueChanged += new System.EventHandler(this.languageCmb_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(434, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBtn.Size = new System.Drawing.Size(24, 27);
            this.deleteBtn.StyleController = this.layoutControl1;
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.preferenceLbl});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(470, 53);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deleteBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(28, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.languageCmb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(277, 33);
            this.layoutControlItem1.Text = "Dil";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 16);
            // 
            // preferenceLbl
            // 
            this.preferenceLbl.Control = this.preferenceTxt;
            this.preferenceLbl.Location = new System.Drawing.Point(277, 0);
            this.preferenceLbl.Name = "preferenceLbl";
            this.preferenceLbl.Size = new System.Drawing.Size(145, 33);
            this.preferenceLbl.Text = "Üstünlülük";
            this.preferenceLbl.TextSize = new System.Drawing.Size(59, 16);
            // 
            // UserControlTeacherLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserControlTeacherLanguage";
            this.Size = new System.Drawing.Size(470, 53);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preferenceTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenceLbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit preferenceTxt;
        private DevExpress.XtraEditors.SearchLookUpEdit languageCmb;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem preferenceLbl;
    }
}
