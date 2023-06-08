namespace TeachingLoadInfoSystem
{
    partial class EducationPlanGridPerTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationPlanGridPerTeacher));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.educationPlanPerGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSpecialityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutsideAuditoriumHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuditoriumHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLectureHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeminarHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaboratoryHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemestr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeeklyCourseLoad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguageID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.educationPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.selectBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlanPerGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.educationPlanPerGroupsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // educationPlanPerGroupsBindingSource
            // 
            this.educationPlanPerGroupsBindingSource.DataSource = typeof(TeachingLoadInfoSystem.Models.EducationPlanPerGroup);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSpecialityCode,
            this.colSubject,
            this.colSubjectID,
            this.colCreditCount,
            this.colTotalHours,
            this.colOutsideAuditoriumHours,
            this.colAuditoriumHours,
            this.colLectureHours,
            this.colSeminarHours,
            this.colLaboratoryHours,
            this.colSemestr,
            this.colWeeklyCourseLoad,
            this.colGroupName,
            this.colGroupCourse,
            this.colLanguageID,
            this.colID});
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colSpecialityCode
            // 
            this.colSpecialityCode.FieldName = "SpecialityCode";
            this.colSpecialityCode.MinWidth = 25;
            this.colSpecialityCode.Name = "colSpecialityCode";
            this.colSpecialityCode.Visible = true;
            this.colSpecialityCode.VisibleIndex = 1;
            this.colSpecialityCode.Width = 94;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject.SubjectName";
            this.colSubject.MinWidth = 25;
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 2;
            this.colSubject.Width = 94;
            // 
            // colSubjectID
            // 
            this.colSubjectID.FieldName = "SubjectID";
            this.colSubjectID.MinWidth = 25;
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.Visible = true;
            this.colSubjectID.VisibleIndex = 3;
            this.colSubjectID.Width = 94;
            // 
            // colCreditCount
            // 
            this.colCreditCount.FieldName = "CreditCount";
            this.colCreditCount.MinWidth = 25;
            this.colCreditCount.Name = "colCreditCount";
            this.colCreditCount.Visible = true;
            this.colCreditCount.VisibleIndex = 4;
            this.colCreditCount.Width = 94;
            // 
            // colTotalHours
            // 
            this.colTotalHours.FieldName = "TotalHours";
            this.colTotalHours.MinWidth = 25;
            this.colTotalHours.Name = "colTotalHours";
            this.colTotalHours.Visible = true;
            this.colTotalHours.VisibleIndex = 5;
            this.colTotalHours.Width = 94;
            // 
            // colOutsideAuditoriumHours
            // 
            this.colOutsideAuditoriumHours.FieldName = "OutsideAuditoriumHours";
            this.colOutsideAuditoriumHours.MinWidth = 25;
            this.colOutsideAuditoriumHours.Name = "colOutsideAuditoriumHours";
            this.colOutsideAuditoriumHours.Visible = true;
            this.colOutsideAuditoriumHours.VisibleIndex = 6;
            this.colOutsideAuditoriumHours.Width = 94;
            // 
            // colAuditoriumHours
            // 
            this.colAuditoriumHours.FieldName = "AuditoriumHours";
            this.colAuditoriumHours.MinWidth = 25;
            this.colAuditoriumHours.Name = "colAuditoriumHours";
            this.colAuditoriumHours.Visible = true;
            this.colAuditoriumHours.VisibleIndex = 7;
            this.colAuditoriumHours.Width = 94;
            // 
            // colLectureHours
            // 
            this.colLectureHours.FieldName = "LectureHours";
            this.colLectureHours.MinWidth = 25;
            this.colLectureHours.Name = "colLectureHours";
            this.colLectureHours.Visible = true;
            this.colLectureHours.VisibleIndex = 8;
            this.colLectureHours.Width = 94;
            // 
            // colSeminarHours
            // 
            this.colSeminarHours.FieldName = "SeminarHours";
            this.colSeminarHours.MinWidth = 25;
            this.colSeminarHours.Name = "colSeminarHours";
            this.colSeminarHours.Visible = true;
            this.colSeminarHours.VisibleIndex = 9;
            this.colSeminarHours.Width = 94;
            // 
            // colLaboratoryHours
            // 
            this.colLaboratoryHours.FieldName = "LaboratoryHours";
            this.colLaboratoryHours.MinWidth = 25;
            this.colLaboratoryHours.Name = "colLaboratoryHours";
            this.colLaboratoryHours.Visible = true;
            this.colLaboratoryHours.VisibleIndex = 10;
            this.colLaboratoryHours.Width = 94;
            // 
            // colSemestr
            // 
            this.colSemestr.FieldName = "Semestr";
            this.colSemestr.MinWidth = 25;
            this.colSemestr.Name = "colSemestr";
            this.colSemestr.Visible = true;
            this.colSemestr.VisibleIndex = 11;
            this.colSemestr.Width = 94;
            // 
            // colWeeklyCourseLoad
            // 
            this.colWeeklyCourseLoad.FieldName = "WeeklyCourseLoad";
            this.colWeeklyCourseLoad.MinWidth = 25;
            this.colWeeklyCourseLoad.Name = "colWeeklyCourseLoad";
            this.colWeeklyCourseLoad.Visible = true;
            this.colWeeklyCourseLoad.VisibleIndex = 12;
            this.colWeeklyCourseLoad.Width = 94;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.MinWidth = 25;
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 13;
            this.colGroupName.Width = 94;
            // 
            // colGroupCourse
            // 
            this.colGroupCourse.FieldName = "GroupCourse";
            this.colGroupCourse.MinWidth = 25;
            this.colGroupCourse.Name = "colGroupCourse";
            this.colGroupCourse.Visible = true;
            this.colGroupCourse.VisibleIndex = 14;
            this.colGroupCourse.Width = 94;
            // 
            // colLanguageID
            // 
            this.colLanguageID.FieldName = "LanguageID";
            this.colLanguageID.MinWidth = 25;
            this.colLanguageID.Name = "colLanguageID";
            this.colLanguageID.Visible = true;
            this.colLanguageID.VisibleIndex = 15;
            this.colLanguageID.Width = 94;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 16;
            this.colID.Width = 94;
            // 
            // educationPlansBindingSource
            // 
            this.educationPlansBindingSource.DataSource = typeof(TeachingLoadInfoSystem.Models.EducationPlan);
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
            this.selectBtn});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.selectBtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // selectBtn
            // 
            this.selectBtn.Caption = "Seç";
            this.selectBtn.Id = 0;
            this.selectBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("selectBtn.ImageOptions.SvgImage")));
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.selectBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.selectBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(869, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(869, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // EducationPlanGridPerTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EducationPlanGridPerTeacher";
            this.Text = "EducationPlanGridPerTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlanPerGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource educationPlansBindingSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem selectBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private BindingSource educationPlanPerGroupsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecialityCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalHours;
        private DevExpress.XtraGrid.Columns.GridColumn colOutsideAuditoriumHours;
        private DevExpress.XtraGrid.Columns.GridColumn colAuditoriumHours;
        private DevExpress.XtraGrid.Columns.GridColumn colLectureHours;
        private DevExpress.XtraGrid.Columns.GridColumn colSeminarHours;
        private DevExpress.XtraGrid.Columns.GridColumn colLaboratoryHours;
        private DevExpress.XtraGrid.Columns.GridColumn colSemestr;
        private DevExpress.XtraGrid.Columns.GridColumn colWeeklyCourseLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCourse;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguageID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}