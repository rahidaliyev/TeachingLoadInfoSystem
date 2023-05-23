namespace TeachingLoadInfoSystem
{
    partial class TLExcludedInnerGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLExcludedInnerGridForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.teachingLoadSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTeachingLoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjects = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExerciseFirstSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLectureFirstSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaboratoryFirstSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecommendationFirstSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExamFirstSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstSemSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExerciseSecondSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLectureSecondSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaboratorySecondSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecommendationSecondSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExamSecondSem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPractise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEPedTETedTTKITA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThesis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterThesis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctorate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondSemSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.newBtn = new DevExpress.XtraBars.BarButtonItem();
            this.previewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingLoadSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.teachingLoadSubjectsBindingSource;
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
            // teachingLoadSubjectsBindingSource
            // 
            this.teachingLoadSubjectsBindingSource.DataSource = typeof(TeachingLoadInfoSystem.Models.TeachingLoadSubject);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTeachingLoadID,
            this.colSubjects,
            this.colSubjectID,
            this.colExerciseFirstSem,
            this.colLectureFirstSem,
            this.colLaboratoryFirstSem,
            this.colRecommendationFirstSem,
            this.colExamFirstSem,
            this.colFirstSemSum,
            this.colExerciseSecondSem,
            this.colLectureSecondSem,
            this.colLaboratorySecondSem,
            this.colRecommendationSecondSem,
            this.colExamSecondSem,
            this.colPrLeader,
            this.colPractise,
            this.colEPedTETedTTKITA,
            this.colThesis,
            this.colMasterThesis,
            this.colDoctorate,
            this.colSecondSemSum,
            this.colFinalResult,
            this.colID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsImageLoad.DesiredThumbnailSize = new System.Drawing.Size(200, 0);
            // 
            // colTeachingLoadID
            // 
            this.colTeachingLoadID.FieldName = "TeachingLoadID";
            this.colTeachingLoadID.MinWidth = 25;
            this.colTeachingLoadID.Name = "colTeachingLoadID";
            this.colTeachingLoadID.Visible = true;
            this.colTeachingLoadID.VisibleIndex = 0;
            this.colTeachingLoadID.Width = 94;
            // 
            // colSubjects
            // 
            this.colSubjects.FieldName = "SubjectCode";
            this.colSubjects.MinWidth = 25;
            this.colSubjects.Name = "colSubjects";
            this.colSubjects.Visible = true;
            this.colSubjects.VisibleIndex = 1;
            this.colSubjects.Width = 94;
            // 
            // colSubjectID
            // 
            this.colSubjectID.FieldName = "SubjectID";
            this.colSubjectID.MinWidth = 25;
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.Visible = true;
            this.colSubjectID.VisibleIndex = 2;
            this.colSubjectID.Width = 94;
            // 
            // colExerciseFirstSem
            // 
            this.colExerciseFirstSem.FieldName = "ExerciseFirstSem";
            this.colExerciseFirstSem.MinWidth = 25;
            this.colExerciseFirstSem.Name = "colExerciseFirstSem";
            this.colExerciseFirstSem.Visible = true;
            this.colExerciseFirstSem.VisibleIndex = 3;
            this.colExerciseFirstSem.Width = 94;
            // 
            // colLectureFirstSem
            // 
            this.colLectureFirstSem.FieldName = "LectureFirstSem";
            this.colLectureFirstSem.MinWidth = 25;
            this.colLectureFirstSem.Name = "colLectureFirstSem";
            this.colLectureFirstSem.Visible = true;
            this.colLectureFirstSem.VisibleIndex = 4;
            this.colLectureFirstSem.Width = 94;
            // 
            // colLaboratoryFirstSem
            // 
            this.colLaboratoryFirstSem.FieldName = "LaboratoryFirstSem";
            this.colLaboratoryFirstSem.MinWidth = 25;
            this.colLaboratoryFirstSem.Name = "colLaboratoryFirstSem";
            this.colLaboratoryFirstSem.Visible = true;
            this.colLaboratoryFirstSem.VisibleIndex = 5;
            this.colLaboratoryFirstSem.Width = 94;
            // 
            // colRecommendationFirstSem
            // 
            this.colRecommendationFirstSem.FieldName = "RecommendationFirstSem";
            this.colRecommendationFirstSem.MinWidth = 25;
            this.colRecommendationFirstSem.Name = "colRecommendationFirstSem";
            this.colRecommendationFirstSem.Visible = true;
            this.colRecommendationFirstSem.VisibleIndex = 6;
            this.colRecommendationFirstSem.Width = 94;
            // 
            // colExamFirstSem
            // 
            this.colExamFirstSem.FieldName = "ExamFirstSem";
            this.colExamFirstSem.MinWidth = 25;
            this.colExamFirstSem.Name = "colExamFirstSem";
            this.colExamFirstSem.Visible = true;
            this.colExamFirstSem.VisibleIndex = 7;
            this.colExamFirstSem.Width = 94;
            // 
            // colFirstSemSum
            // 
            this.colFirstSemSum.FieldName = "FirstSemSum";
            this.colFirstSemSum.MinWidth = 25;
            this.colFirstSemSum.Name = "colFirstSemSum";
            this.colFirstSemSum.Visible = true;
            this.colFirstSemSum.VisibleIndex = 8;
            this.colFirstSemSum.Width = 94;
            // 
            // colExerciseSecondSem
            // 
            this.colExerciseSecondSem.FieldName = "ExerciseSecondSem";
            this.colExerciseSecondSem.MinWidth = 25;
            this.colExerciseSecondSem.Name = "colExerciseSecondSem";
            this.colExerciseSecondSem.Visible = true;
            this.colExerciseSecondSem.VisibleIndex = 9;
            this.colExerciseSecondSem.Width = 94;
            // 
            // colLectureSecondSem
            // 
            this.colLectureSecondSem.FieldName = "LectureSecondSem";
            this.colLectureSecondSem.MinWidth = 25;
            this.colLectureSecondSem.Name = "colLectureSecondSem";
            this.colLectureSecondSem.Visible = true;
            this.colLectureSecondSem.VisibleIndex = 10;
            this.colLectureSecondSem.Width = 94;
            // 
            // colLaboratorySecondSem
            // 
            this.colLaboratorySecondSem.FieldName = "LaboratorySecondSem";
            this.colLaboratorySecondSem.MinWidth = 25;
            this.colLaboratorySecondSem.Name = "colLaboratorySecondSem";
            this.colLaboratorySecondSem.Visible = true;
            this.colLaboratorySecondSem.VisibleIndex = 11;
            this.colLaboratorySecondSem.Width = 94;
            // 
            // colRecommendationSecondSem
            // 
            this.colRecommendationSecondSem.FieldName = "RecommendationSecondSem";
            this.colRecommendationSecondSem.MinWidth = 25;
            this.colRecommendationSecondSem.Name = "colRecommendationSecondSem";
            this.colRecommendationSecondSem.Visible = true;
            this.colRecommendationSecondSem.VisibleIndex = 12;
            this.colRecommendationSecondSem.Width = 94;
            // 
            // colExamSecondSem
            // 
            this.colExamSecondSem.FieldName = "ExamSecondSem";
            this.colExamSecondSem.MinWidth = 25;
            this.colExamSecondSem.Name = "colExamSecondSem";
            this.colExamSecondSem.Visible = true;
            this.colExamSecondSem.VisibleIndex = 13;
            this.colExamSecondSem.Width = 94;
            // 
            // colPrLeader
            // 
            this.colPrLeader.FieldName = "PrLeader";
            this.colPrLeader.MinWidth = 25;
            this.colPrLeader.Name = "colPrLeader";
            this.colPrLeader.Visible = true;
            this.colPrLeader.VisibleIndex = 14;
            this.colPrLeader.Width = 94;
            // 
            // colPractise
            // 
            this.colPractise.FieldName = "Practise";
            this.colPractise.MinWidth = 25;
            this.colPractise.Name = "colPractise";
            this.colPractise.Visible = true;
            this.colPractise.VisibleIndex = 15;
            this.colPractise.Width = 94;
            // 
            // colEPedTETedTTKITA
            // 
            this.colEPedTETedTTKITA.FieldName = "EPedTETedTTKITA";
            this.colEPedTETedTTKITA.MinWidth = 25;
            this.colEPedTETedTTKITA.Name = "colEPedTETedTTKITA";
            this.colEPedTETedTTKITA.Visible = true;
            this.colEPedTETedTTKITA.VisibleIndex = 16;
            this.colEPedTETedTTKITA.Width = 94;
            // 
            // colThesis
            // 
            this.colThesis.FieldName = "Thesis";
            this.colThesis.MinWidth = 25;
            this.colThesis.Name = "colThesis";
            this.colThesis.Visible = true;
            this.colThesis.VisibleIndex = 17;
            this.colThesis.Width = 94;
            // 
            // colMasterThesis
            // 
            this.colMasterThesis.FieldName = "MasterThesis";
            this.colMasterThesis.MinWidth = 25;
            this.colMasterThesis.Name = "colMasterThesis";
            this.colMasterThesis.Visible = true;
            this.colMasterThesis.VisibleIndex = 18;
            this.colMasterThesis.Width = 94;
            // 
            // colDoctorate
            // 
            this.colDoctorate.FieldName = "Doctorate";
            this.colDoctorate.MinWidth = 25;
            this.colDoctorate.Name = "colDoctorate";
            this.colDoctorate.Visible = true;
            this.colDoctorate.VisibleIndex = 19;
            this.colDoctorate.Width = 94;
            // 
            // colSecondSemSum
            // 
            this.colSecondSemSum.FieldName = "SecondSemSum";
            this.colSecondSemSum.MinWidth = 25;
            this.colSecondSemSum.Name = "colSecondSemSum";
            this.colSecondSemSum.Visible = true;
            this.colSecondSemSum.VisibleIndex = 20;
            this.colSecondSemSum.Width = 94;
            // 
            // colFinalResult
            // 
            this.colFinalResult.FieldName = "FinalResult";
            this.colFinalResult.MinWidth = 25;
            this.colFinalResult.Name = "colFinalResult";
            this.colFinalResult.Visible = true;
            this.colFinalResult.VisibleIndex = 21;
            this.colFinalResult.Width = 94;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 22;
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
            this.RefreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteBtn)});
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
            // TLExcludedInnerGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 559);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TLExcludedInnerGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingLoadSubjectsBindingSource)).EndInit();
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
        private BindingSource teachingLoadSubjectsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachingLoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjects;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colExerciseFirstSem;
        private DevExpress.XtraGrid.Columns.GridColumn colLectureFirstSem;
        private DevExpress.XtraGrid.Columns.GridColumn colLaboratoryFirstSem;
        private DevExpress.XtraGrid.Columns.GridColumn colRecommendationFirstSem;
        private DevExpress.XtraGrid.Columns.GridColumn colExamFirstSem;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstSemSum;
        private DevExpress.XtraGrid.Columns.GridColumn colExerciseSecondSem;
        private DevExpress.XtraGrid.Columns.GridColumn colLectureSecondSem;
        private DevExpress.XtraGrid.Columns.GridColumn colLaboratorySecondSem;
        private DevExpress.XtraGrid.Columns.GridColumn colRecommendationSecondSem;
        private DevExpress.XtraGrid.Columns.GridColumn colExamSecondSem;
        private DevExpress.XtraGrid.Columns.GridColumn colPrLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colPractise;
        private DevExpress.XtraGrid.Columns.GridColumn colEPedTETedTTKITA;
        private DevExpress.XtraGrid.Columns.GridColumn colThesis;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterThesis;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctorate;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondSemSum;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalResult;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}