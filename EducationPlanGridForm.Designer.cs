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
            components = new System.ComponentModel.Container();
            speciality1Btn = new DevExpress.XtraEditors.SimpleButton();
            speciality2Btn = new DevExpress.XtraEditors.SimpleButton();
            speciality3Btn = new DevExpress.XtraEditors.SimpleButton();
            speciality4Btn = new DevExpress.XtraEditors.SimpleButton();
            speciality5Btn = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            backBtn = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // speciality1Btn
            // 
            speciality1Btn.Location = new Point(378, 111);
            speciality1Btn.Name = "speciality1Btn";
            speciality1Btn.Size = new Size(118, 36);
            speciality1Btn.TabIndex = 0;
            speciality1Btn.Text = "Ixtisas I";
            speciality1Btn.Click += speciality1Btn_Click;
            // 
            // speciality2Btn
            // 
            speciality2Btn.Location = new Point(378, 173);
            speciality2Btn.Name = "speciality2Btn";
            speciality2Btn.Size = new Size(118, 36);
            speciality2Btn.TabIndex = 1;
            speciality2Btn.Text = "İxtisas II";
            speciality2Btn.Click += specaility2Btn_Click;
            // 
            // speciality3Btn
            // 
            speciality3Btn.Location = new Point(378, 234);
            speciality3Btn.Name = "speciality3Btn";
            speciality3Btn.Size = new Size(118, 36);
            speciality3Btn.TabIndex = 2;
            speciality3Btn.Text = "İxtisas III";
            speciality3Btn.Click += speciality3Btn_Click;
            // 
            // speciality4Btn
            // 
            speciality4Btn.Location = new Point(378, 299);
            speciality4Btn.Name = "speciality4Btn";
            speciality4Btn.Size = new Size(118, 36);
            speciality4Btn.TabIndex = 3;
            speciality4Btn.Text = "İxtisas IV";
            speciality4Btn.Click += speciality4Btn_Click;
            // 
            // speciality5Btn
            // 
            speciality5Btn.Location = new Point(378, 368);
            speciality5Btn.Name = "speciality5Btn";
            speciality5Btn.Size = new Size(118, 36);
            speciality5Btn.TabIndex = 4;
            speciality5Btn.Text = "Ixtisas V";
            speciality5Btn.Click += speciality5Btn_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 25);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(911, 523);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Visible = false;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { backBtn });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(backBtn) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // backBtn
            // 
            backBtn.Caption = "barButtonItem1";
            backBtn.Id = 0;
            backBtn.Name = "backBtn";
            backBtn.ItemClick += backBtn_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(911, 25);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 548);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(911, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 25);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 523);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(911, 25);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 523);
            // 
            // EducationPlanGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 548);
            Controls.Add(gridControl1);
            Controls.Add(speciality5Btn);
            Controls.Add(speciality4Btn);
            Controls.Add(speciality3Btn);
            Controls.Add(speciality2Btn);
            Controls.Add(speciality1Btn);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "EducationPlanGridForm";
            Text = "EducationPlan";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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