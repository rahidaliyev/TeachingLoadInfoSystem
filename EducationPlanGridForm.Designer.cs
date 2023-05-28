namespace TeachingLoadInfoSystem
{
    partial class EducationPlanGridForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationPlanGridForm));
            this.speciality1Btn = new DevExpress.XtraEditors.SimpleButton();
            this.speciality2Btn = new DevExpress.XtraEditors.SimpleButton();
            this.speciality3Btn = new DevExpress.XtraEditors.SimpleButton();
            this.speciality4Btn = new DevExpress.XtraEditors.SimpleButton();
            this.speciality5Btn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.backBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // speciality1Btn
            // 
            this.speciality1Btn.Location = new System.Drawing.Point(39, 97);
            this.speciality1Btn.Name = "speciality1Btn";
            this.speciality1Btn.Size = new System.Drawing.Size(118, 36);
            this.speciality1Btn.TabIndex = 0;
            this.speciality1Btn.Text = "Ixtisas I";
            this.speciality1Btn.Click += new System.EventHandler(this.speciality1Btn_Click);
            // 
            // speciality2Btn
            // 
            this.speciality2Btn.Location = new System.Drawing.Point(39, 159);
            this.speciality2Btn.Name = "speciality2Btn";
            this.speciality2Btn.Size = new System.Drawing.Size(118, 36);
            this.speciality2Btn.TabIndex = 1;
            this.speciality2Btn.Text = "İxtisas II";
            this.speciality2Btn.Click += new System.EventHandler(this.specaility2Btn_Click);
            // 
            // speciality3Btn
            // 
            this.speciality3Btn.Location = new System.Drawing.Point(39, 220);
            this.speciality3Btn.Name = "speciality3Btn";
            this.speciality3Btn.Size = new System.Drawing.Size(118, 36);
            this.speciality3Btn.TabIndex = 2;
            this.speciality3Btn.Text = "İxtisas III";
            this.speciality3Btn.Click += new System.EventHandler(this.speciality3Btn_Click);
            // 
            // speciality4Btn
            // 
            this.speciality4Btn.Location = new System.Drawing.Point(39, 285);
            this.speciality4Btn.Name = "speciality4Btn";
            this.speciality4Btn.Size = new System.Drawing.Size(118, 36);
            this.speciality4Btn.TabIndex = 3;
            this.speciality4Btn.Text = "İxtisas IV";
            this.speciality4Btn.Click += new System.EventHandler(this.speciality4Btn_Click);
            // 
            // speciality5Btn
            // 
            this.speciality5Btn.Location = new System.Drawing.Point(39, 354);
            this.speciality5Btn.Name = "speciality5Btn";
            this.speciality5Btn.Size = new System.Drawing.Size(118, 36);
            this.speciality5Btn.TabIndex = 4;
            this.speciality5Btn.Text = "Ixtisas V";
            this.speciality5Btn.Click += new System.EventHandler(this.speciality5Btn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(911, 518);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.backBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.backBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // backBtn
            // 
            this.backBtn.Caption = "Geri";
            this.backBtn.Id = 0;
            this.backBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backBtn.ImageOptions.SvgImage")));
            this.backBtn.Name = "backBtn";
            this.backBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.backBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.backBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(911, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(911, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(911, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // EducationPlanGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.speciality5Btn);
            this.Controls.Add(this.speciality4Btn);
            this.Controls.Add(this.speciality3Btn);
            this.Controls.Add(this.speciality2Btn);
            this.Controls.Add(this.speciality1Btn);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EducationPlanGridForm";
            this.Text = "EducationPlan";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton speciality1Btn;
        private DevExpress.XtraEditors.SimpleButton speciality2Btn;
        private DevExpress.XtraEditors.SimpleButton speciality3Btn;
        private DevExpress.XtraEditors.SimpleButton speciality4Btn;
        private DevExpress.XtraEditors.SimpleButton speciality5Btn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem backBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}