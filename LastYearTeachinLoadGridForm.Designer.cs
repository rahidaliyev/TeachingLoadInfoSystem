﻿namespace TeachingLoadInfoSystem
{
    partial class LastYearTeachinLoadGridForm
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlanPerGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.educationPlanPerGroupsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(700, 360);
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
            // 
            // colSpecialityCode
            // 
            this.colSpecialityCode.FieldName = "SpecialityCode";
            this.colSpecialityCode.MinWidth = 25;
            this.colSpecialityCode.Name = "colSpecialityCode";
            this.colSpecialityCode.Visible = true;
            this.colSpecialityCode.VisibleIndex = 0;
            this.colSpecialityCode.Width = 94;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.MinWidth = 25;
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 1;
            this.colSubject.Width = 94;
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
            // colCreditCount
            // 
            this.colCreditCount.FieldName = "CreditCount";
            this.colCreditCount.MinWidth = 25;
            this.colCreditCount.Name = "colCreditCount";
            this.colCreditCount.Visible = true;
            this.colCreditCount.VisibleIndex = 3;
            this.colCreditCount.Width = 94;
            // 
            // colTotalHours
            // 
            this.colTotalHours.FieldName = "TotalHours";
            this.colTotalHours.MinWidth = 25;
            this.colTotalHours.Name = "colTotalHours";
            this.colTotalHours.Visible = true;
            this.colTotalHours.VisibleIndex = 4;
            this.colTotalHours.Width = 94;
            // 
            // colOutsideAuditoriumHours
            // 
            this.colOutsideAuditoriumHours.FieldName = "OutsideAuditoriumHours";
            this.colOutsideAuditoriumHours.MinWidth = 25;
            this.colOutsideAuditoriumHours.Name = "colOutsideAuditoriumHours";
            this.colOutsideAuditoriumHours.Visible = true;
            this.colOutsideAuditoriumHours.VisibleIndex = 5;
            this.colOutsideAuditoriumHours.Width = 94;
            // 
            // colAuditoriumHours
            // 
            this.colAuditoriumHours.FieldName = "AuditoriumHours";
            this.colAuditoriumHours.MinWidth = 25;
            this.colAuditoriumHours.Name = "colAuditoriumHours";
            this.colAuditoriumHours.Visible = true;
            this.colAuditoriumHours.VisibleIndex = 6;
            this.colAuditoriumHours.Width = 94;
            // 
            // colLectureHours
            // 
            this.colLectureHours.FieldName = "LectureHours";
            this.colLectureHours.MinWidth = 25;
            this.colLectureHours.Name = "colLectureHours";
            this.colLectureHours.Visible = true;
            this.colLectureHours.VisibleIndex = 7;
            this.colLectureHours.Width = 94;
            // 
            // colSeminarHours
            // 
            this.colSeminarHours.FieldName = "SeminarHours";
            this.colSeminarHours.MinWidth = 25;
            this.colSeminarHours.Name = "colSeminarHours";
            this.colSeminarHours.Visible = true;
            this.colSeminarHours.VisibleIndex = 8;
            this.colSeminarHours.Width = 94;
            // 
            // colLaboratoryHours
            // 
            this.colLaboratoryHours.FieldName = "LaboratoryHours";
            this.colLaboratoryHours.MinWidth = 25;
            this.colLaboratoryHours.Name = "colLaboratoryHours";
            this.colLaboratoryHours.Visible = true;
            this.colLaboratoryHours.VisibleIndex = 9;
            this.colLaboratoryHours.Width = 94;
            // 
            // colSemestr
            // 
            this.colSemestr.FieldName = "Semestr";
            this.colSemestr.MinWidth = 25;
            this.colSemestr.Name = "colSemestr";
            this.colSemestr.Visible = true;
            this.colSemestr.VisibleIndex = 10;
            this.colSemestr.Width = 94;
            // 
            // colWeeklyCourseLoad
            // 
            this.colWeeklyCourseLoad.FieldName = "WeeklyCourseLoad";
            this.colWeeklyCourseLoad.MinWidth = 25;
            this.colWeeklyCourseLoad.Name = "colWeeklyCourseLoad";
            this.colWeeklyCourseLoad.Visible = true;
            this.colWeeklyCourseLoad.VisibleIndex = 11;
            this.colWeeklyCourseLoad.Width = 94;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.MinWidth = 25;
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 12;
            this.colGroupName.Width = 94;
            // 
            // colGroupCourse
            // 
            this.colGroupCourse.FieldName = "GroupCourse";
            this.colGroupCourse.MinWidth = 25;
            this.colGroupCourse.Name = "colGroupCourse";
            this.colGroupCourse.Visible = true;
            this.colGroupCourse.VisibleIndex = 13;
            this.colGroupCourse.Width = 94;
            // 
            // colLanguageID
            // 
            this.colLanguageID.FieldName = "LanguageID";
            this.colLanguageID.MinWidth = 25;
            this.colLanguageID.Name = "colLanguageID";
            this.colLanguageID.Visible = true;
            this.colLanguageID.VisibleIndex = 14;
            this.colLanguageID.Width = 94;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 15;
            this.colID.Width = 94;
            // 
            // LastYearTeachinLoadGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LastYearTeachinLoadGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keçən ilin tədris yükü";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationPlanPerGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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