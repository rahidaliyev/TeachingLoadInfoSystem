namespace TeachingLoadInfoSystem
{
    partial class UserControlBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBook));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.isTextBookCheck = new DevExpress.XtraEditors.CheckEdit();
            this.bookNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isTextBookCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deleteBtn);
            this.layoutControl1.Controls.Add(this.isTextBookCheck);
            this.layoutControl1.Controls.Add(this.bookNameTxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(545, 68);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(481, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBtn.Size = new System.Drawing.Size(52, 27);
            this.deleteBtn.StyleController = this.layoutControl1;
            this.deleteBtn.TabIndex = 4;
            // 
            // isTextBookCheck
            // 
            this.isTextBookCheck.Location = new System.Drawing.Point(410, 12);
            this.isTextBookCheck.Name = "isTextBookCheck";
            this.isTextBookCheck.Properties.Caption = "Dərslik";
            this.isTextBookCheck.Size = new System.Drawing.Size(67, 24);
            this.isTextBookCheck.StyleController = this.layoutControl1;
            this.isTextBookCheck.TabIndex = 3;
            this.isTextBookCheck.CheckedChanged += new System.EventHandler(this.isTextBookCheck_CheckedChanged);

            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Location = new System.Drawing.Point(73, 12);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.Size = new System.Drawing.Size(333, 22);
            this.bookNameTxt.StyleController = this.layoutControl1;
            this.bookNameTxt.TabIndex = 0;
            this.bookNameTxt.EditValueChanged += new System.EventHandler(this.bookNameTxt_EditValueChanged);

            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 68);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bookNameTxt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(398, 48);
            this.layoutControlItem1.Text = "Kitab adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.isTextBookCheck;
            this.layoutControlItem2.Location = new System.Drawing.Point(398, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(71, 48);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deleteBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(469, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(56, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // BookUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "BookUserControl1";
            this.Size = new System.Drawing.Size(545, 68);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isTextBookCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit isTextBookCheck;
        private DevExpress.XtraEditors.TextEdit bookNameTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
