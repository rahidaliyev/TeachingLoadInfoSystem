using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem
{
    partial class VacancyGridForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacancyGridForm));
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            ExcelTest = new DevExpress.XtraBars.BarButtonItem();
            WordBtn = new DevExpress.XtraBars.BarButtonItem();
            PDFBtn = new DevExpress.XtraBars.BarButtonItem();
            HTMLBtn = new DevExpress.XtraBars.BarButtonItem();
            saveLayoutBtn = new DevExpress.XtraBars.BarButtonItem();
            downloadTemplateBtn = new DevExpress.XtraBars.BarButtonItem();
            importBtn = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 30);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(1114, 529);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridControl.DoubleClick += gridControl_DoubleClick;
            // 
            // gridView
            // 
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { DeleteBtn, RefreshBtn, barSubItem1, ExcelTest, WordBtn, PDFBtn, HTMLBtn, saveLayoutBtn, downloadTemplateBtn, importBtn });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 18;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(RefreshBtn), new DevExpress.XtraBars.LinkPersistInfo(DeleteBtn), new DevExpress.XtraBars.LinkPersistInfo(barSubItem1), new DevExpress.XtraBars.LinkPersistInfo(saveLayoutBtn), new DevExpress.XtraBars.LinkPersistInfo(downloadTemplateBtn), new DevExpress.XtraBars.LinkPersistInfo(importBtn) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Caption = "Refresh";
            RefreshBtn.Id = 3;
            RefreshBtn.ImageOptions.Image = (Image)resources.GetObject("RefreshBtn.ImageOptions.Image");
            RefreshBtn.ImageOptions.LargeImage = (Image)resources.GetObject("RefreshBtn.ImageOptions.LargeImage");
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            RefreshBtn.ItemClick += RefreshBtn_ItemClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Caption = "Delete";
            DeleteBtn.Id = 2;
            DeleteBtn.ImageOptions.Image = (Image)resources.GetObject("DeleteBtn.ImageOptions.Image");
            DeleteBtn.ImageOptions.LargeImage = (Image)resources.GetObject("DeleteBtn.ImageOptions.LargeImage");
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            DeleteBtn.ItemClick += DeleteBtn_ItemClick;
            // 
            // barSubItem1
            // 
            barSubItem1.Caption = "Export";
            barSubItem1.Id = 10;
            barSubItem1.ImageOptions.Image = (Image)resources.GetObject("barSubItem1.ImageOptions.Image");
            barSubItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barSubItem1.ImageOptions.LargeImage");
            barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(ExcelTest), new DevExpress.XtraBars.LinkPersistInfo(WordBtn), new DevExpress.XtraBars.LinkPersistInfo(PDFBtn), new DevExpress.XtraBars.LinkPersistInfo(HTMLBtn) });
            barSubItem1.Name = "barSubItem1";
            barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ExcelTest
            // 
            ExcelTest.Caption = "EXCEL";
            ExcelTest.Id = 11;
            ExcelTest.Name = "ExcelTest";
            ExcelTest.ItemClick += ExcelTest_ItemClick;
            // 
            // WordBtn
            // 
            WordBtn.Caption = "Word";
            WordBtn.Id = 12;
            WordBtn.Name = "WordBtn";
            WordBtn.ItemClick += WordBtn_ItemClick;
            // 
            // PDFBtn
            // 
            PDFBtn.Caption = "PDF";
            PDFBtn.Id = 13;
            PDFBtn.Name = "PDFBtn";
            PDFBtn.ItemClick += PDFBtn_ItemClick;
            // 
            // HTMLBtn
            // 
            HTMLBtn.Caption = "HTML";
            HTMLBtn.Id = 14;
            HTMLBtn.Name = "HTMLBtn";
            HTMLBtn.ItemClick += HTMLBtn_ItemClick;
            // 
            // saveLayoutBtn
            // 
            saveLayoutBtn.Caption = "Şablonu yadda saxla";
            saveLayoutBtn.Id = 15;
            saveLayoutBtn.ImageOptions.Image = (Image)resources.GetObject("saveLayoutBtn.ImageOptions.Image");
            saveLayoutBtn.ImageOptions.LargeImage = (Image)resources.GetObject("saveLayoutBtn.ImageOptions.LargeImage");
            saveLayoutBtn.Name = "saveLayoutBtn";
            saveLayoutBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            saveLayoutBtn.ItemClick += saveLayoutBtn_ItemClick;
            // 
            // downloadTemplateBtn
            // 
            downloadTemplateBtn.Caption = "Şablonu yüklə";
            downloadTemplateBtn.Id = 16;
            downloadTemplateBtn.ImageOptions.Image = (Image)resources.GetObject("downloadTemplateBtn.ImageOptions.Image");
            downloadTemplateBtn.ImageOptions.LargeImage = (Image)resources.GetObject("downloadTemplateBtn.ImageOptions.LargeImage");
            downloadTemplateBtn.Name = "downloadTemplateBtn";
            downloadTemplateBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            downloadTemplateBtn.ItemClick += downloadTemplateBtn_ItemClick;
            // 
            // importBtn
            // 
            importBtn.Caption = "Import Excel";
            importBtn.Id = 17;
            importBtn.ImageOptions.Image = (Image)resources.GetObject("importBtn.ImageOptions.Image");
            importBtn.ImageOptions.LargeImage = (Image)resources.GetObject("importBtn.ImageOptions.LargeImage");
            importBtn.Name = "importBtn";
            importBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            importBtn.ItemClick += importBtn_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1114, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 559);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1114, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 529);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1114, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 529);
            // 
            // VacancyGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 559);
            Controls.Add(gridControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "VacancyGridForm";
            Text = "Form1";
            Load += TeacherInfoGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem DeleteBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem RefreshBtn;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem ExcelTest;
        private DevExpress.XtraBars.BarButtonItem WordBtn;
        private DevExpress.XtraBars.BarButtonItem PDFBtn;
        private DevExpress.XtraBars.BarButtonItem HTMLBtn;
        private DevExpress.XtraBars.BarButtonItem saveLayoutBtn;
        private DevExpress.XtraBars.BarButtonItem downloadTemplateBtn;
        private DevExpress.XtraBars.BarButtonItem importBtn;
    }
}