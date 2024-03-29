﻿using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem
{
    partial class TeacherInfoGridForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfoGridForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.teacherInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTeacherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScientificName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScientificDegree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.newBtn = new DevExpress.XtraBars.BarButtonItem();
            this.previewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ExcelTest = new DevExpress.XtraBars.BarButtonItem();
            this.WordBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PDFBtn = new DevExpress.XtraBars.BarButtonItem();
            this.HTMLBtn = new DevExpress.XtraBars.BarButtonItem();
            this.saveLayoutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.downloadTemplateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.importBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.teacherInfosBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 30);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1114, 529);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // teacherInfosBindingSource
            // 
            this.teacherInfosBindingSource.DataSource = typeof(TeachingLoadInfoSystem.Models.TeacherInfo);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colTeacherName,
            this.colBirthDate,
            this.colEmail,
            this.colPhoneNumber,
            this.colGender,
            this.colScientificName,
            this.colScientificDegree,
            this.colDepartment,
            this.colWorkTime,
            this.colID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            // 
            // colTeacherName
            // 
            this.colTeacherName.Caption = "Ad";
            this.colTeacherName.FieldName = "TeacherFullName";
            this.colTeacherName.MinWidth = 25;
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.Visible = true;
            this.colTeacherName.VisibleIndex = 1;
            this.colTeacherName.Width = 94;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "Doğum tarixi";
            this.colBirthDate.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colBirthDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.GroupFormat.FormatString = "dd-MM-yyyy";
            this.colBirthDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthDate.MinWidth = 25;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            this.colBirthDate.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 94;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Nömrə";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 25;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 4;
            this.colPhoneNumber.Width = 94;
            // 
            // colGender
            // 
            this.colGender.Caption = "Cins";
            this.colGender.FieldName = "Gender.GenderName";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            this.colGender.Width = 94;
            // 
            // colScientificName
            // 
            this.colScientificName.Caption = "Elmi adı";
            this.colScientificName.FieldName = "ScientificName.Name";
            this.colScientificName.MinWidth = 25;
            this.colScientificName.Name = "colScientificName";
            this.colScientificName.Visible = true;
            this.colScientificName.VisibleIndex = 6;
            this.colScientificName.Width = 94;
            // 
            // colScientificDegree
            // 
            this.colScientificDegree.Caption = "Elmi dərəcəsi";
            this.colScientificDegree.FieldName = "ScientificDegree.DegreeName";
            this.colScientificDegree.MinWidth = 25;
            this.colScientificDegree.Name = "colScientificDegree";
            this.colScientificDegree.Visible = true;
            this.colScientificDegree.VisibleIndex = 7;
            this.colScientificDegree.Width = 94;
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "Kafedra";
            this.colDepartment.FieldName = "Department.DepartmentName";
            this.colDepartment.MinWidth = 25;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 8;
            this.colDepartment.Width = 94;
            // 
            // colWorkTime
            // 
            this.colWorkTime.Caption = "Ştat";
            this.colWorkTime.FieldName = "WorkTime.WorkTimeName";
            this.colWorkTime.MinWidth = 25;
            this.colWorkTime.Name = "colWorkTime";
            this.colWorkTime.Visible = true;
            this.colWorkTime.VisibleIndex = 9;
            this.colWorkTime.Width = 94;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 10;
            this.colID.Width = 94;
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
            this.newBtn,
            this.previewBtn,
            this.DeleteBtn,
            this.RefreshBtn,
            this.barSubItem1,
            this.ExcelTest,
            this.WordBtn,
            this.PDFBtn,
            this.HTMLBtn,
            this.saveLayoutBtn,
            this.downloadTemplateBtn,
            this.importBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 18;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.newBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.previewBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.RefreshBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveLayoutBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.downloadTemplateBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.importBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // newBtn
            // 
            this.newBtn.Caption = "New";
            this.newBtn.Id = 0;
            this.newBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.ImageOptions.Image")));
            this.newBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("newBtn.ImageOptions.LargeImage")));
            this.newBtn.Name = "newBtn";
            this.newBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.newBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newBtn_ItemClick);
            // 
            // previewBtn
            // 
            this.previewBtn.Caption = "Preview";
            this.previewBtn.Id = 1;
            this.previewBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("previewBtn.ImageOptions.Image")));
            this.previewBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("previewBtn.ImageOptions.LargeImage")));
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.previewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.previewBtn_ItemClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Caption = "Refresh";
            this.RefreshBtn.Id = 3;
            this.RefreshBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.ImageOptions.Image")));
            this.RefreshBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.ImageOptions.LargeImage")));
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.RefreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Caption = "Delete";
            this.DeleteBtn.Id = 2;
            this.DeleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.ImageOptions.Image")));
            this.DeleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.ImageOptions.LargeImage")));
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DeleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBtn_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Export";
            this.barSubItem1.Id = 10;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ExcelTest),
            new DevExpress.XtraBars.LinkPersistInfo(this.WordBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.PDFBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.HTMLBtn)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ExcelTest
            // 
            this.ExcelTest.Caption = "EXCEL";
            this.ExcelTest.Id = 11;
            this.ExcelTest.Name = "ExcelTest";
            this.ExcelTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExcelTest_ItemClick);
            // 
            // WordBtn
            // 
            this.WordBtn.Caption = "Word";
            this.WordBtn.Id = 12;
            this.WordBtn.Name = "WordBtn";
            this.WordBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.WordBtn_ItemClick);
            // 
            // PDFBtn
            // 
            this.PDFBtn.Caption = "PDF";
            this.PDFBtn.Id = 13;
            this.PDFBtn.Name = "PDFBtn";
            this.PDFBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PDFBtn_ItemClick);
            // 
            // HTMLBtn
            // 
            this.HTMLBtn.Caption = "HTML";
            this.HTMLBtn.Id = 14;
            this.HTMLBtn.Name = "HTMLBtn";
            this.HTMLBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HTMLBtn_ItemClick);
            // 
            // saveLayoutBtn
            // 
            this.saveLayoutBtn.Caption = "Şablonu yadda saxla";
            this.saveLayoutBtn.Id = 15;
            this.saveLayoutBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveLayoutBtn.ImageOptions.Image")));
            this.saveLayoutBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveLayoutBtn.ImageOptions.LargeImage")));
            this.saveLayoutBtn.Name = "saveLayoutBtn";
            this.saveLayoutBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveLayoutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveLayoutBtn_ItemClick);
            // 
            // downloadTemplateBtn
            // 
            this.downloadTemplateBtn.Caption = "Şablonu yüklə";
            this.downloadTemplateBtn.Id = 16;
            this.downloadTemplateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("downloadTemplateBtn.ImageOptions.Image")));
            this.downloadTemplateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("downloadTemplateBtn.ImageOptions.LargeImage")));
            this.downloadTemplateBtn.Name = "downloadTemplateBtn";
            this.downloadTemplateBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.downloadTemplateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.downloadTemplateBtn_ItemClick);
            // 
            // importBtn
            // 
            this.importBtn.Caption = "Import Excel";
            this.importBtn.Id = 17;
            this.importBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.ImageOptions.Image")));
            this.importBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("importBtn.ImageOptions.LargeImage")));
            this.importBtn.Name = "importBtn";
            this.importBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.importBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.importBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1114, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1114, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 529);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1114, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 529);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "TeacherCode";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // TeacherInfoGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 559);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TeacherInfoGridForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TeacherInfoGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem newBtn;
        private DevExpress.XtraBars.BarButtonItem previewBtn;
        private DevExpress.XtraBars.BarButtonItem DeleteBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem RefreshBtn;
        private BindingSource teacherInfosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTeacherName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colScientificName;
        private DevExpress.XtraGrid.Columns.GridColumn colScientificDegree;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkTime;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem ExcelTest;
        private DevExpress.XtraBars.BarButtonItem WordBtn;
        private DevExpress.XtraBars.BarButtonItem PDFBtn;
        private DevExpress.XtraBars.BarButtonItem HTMLBtn;
        private DevExpress.XtraBars.BarButtonItem saveLayoutBtn;
        private DevExpress.XtraBars.BarButtonItem downloadTemplateBtn;
        private DevExpress.XtraBars.BarButtonItem importBtn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}