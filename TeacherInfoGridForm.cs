using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Controllers;
using System.Diagnostics;
using System.IO;
using OfficeOpenXml;

namespace TeachingLoadInfoSystem
{
    public partial class TeacherInfoGridForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo teacherinfo = new TeacherInfo();
        List<TeacherInfo> teacherInfoList = new List<TeacherInfo>();
        Models.LayoutInfo layoutInfo = new Models.LayoutInfo();
        ITeacherInfoServices _teacherInfoServices;
        WorkTime _workTime { get; set; }
        public void RefreshGrid()
        {
            gridControl.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
        }
        private void TeacherInfoGridForm_Load(object sender, EventArgs e)
        {
            gridControl.ForceInitialize();
            LayoutController.RestoreLayout(1, "TeacherGrid", "TeacherForm", gridControl, layoutInfo);
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                teacherinfo = _teacherInfoServices.GetTeacherInfoByID(selectedRow);
                var SkillForm = new TeacherInfoCRUDForm(teacherinfo, _teacherInfoServices);
                SkillForm.ShowDialog();
                RefreshGrid();
                teacherinfo = new TeacherInfo();
            }
            else
            {
                MessageBox.Show("Hər hansı bir sətri seçin!");
            }
            RefreshGrid();
        }
        public void RemoveData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var message = MessageBox.Show("Məlumatı silməyə əminsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                    var selectedCode = gridView.GetFocusedRowCellValue("WorkTimeCode");

                    _teacherInfoServices.DeleteTeacherInfo(selectedRow);
                    RefreshGrid();

                    MessageBox.Show(selectedCode + " kodlu məlumat uğurla silindi.");
                }
                else
                {
                    MessageBox.Show("Hər hansı bir sətri seçin.");
                }
                RefreshGrid();
            }
        }
        public TeacherInfoGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeacherInfoCRUDForm frm = new TeacherInfoCRUDForm(teacherinfo, _teacherInfoServices);
            frm.Show();
            RefreshGrid();
            teacherinfo = new TeacherInfo();
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void previewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreviewData();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            PreviewData();
        }

        private void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RemoveData();
        }
        private void ExcelTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToExcel("TeacherInfo", gridControl);
        }

        private void WordBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToWord("TeacherInfo", gridControl);
        }

        private void PDFBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToPDF("TeacherInfo", gridControl);
        }

        private void HTMLBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToHTML("TeacherInfo", gridControl);
        }

        private void saveLayoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LayoutController.SaveLayout(1, "TeacherGrid", "TeacherForm", gridView, layoutInfo);
        }

        private void downloadTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = @"Excel(*.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var ep = new ExcelPackage(new FileInfo(dlg.FileName));
                var ws = ep.Workbook.Worksheets.FirstOrDefault();
                if (ws == null)
                    ws = ep.Workbook.Worksheets.Add("Sheet1");
                ws.TabColor = Color.Black;
                ws.DefaultRowHeight = 12;
                ws.Row(1).Height = 16;
                ws.Row(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Row(1).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Row(1).Style.Font.Bold = true;
                ws.Row(1).Style.Font.Size = 12;
                ws.Cells[1, 1].Value = "TeacherName";
                ws.Cells[1, 2].Value = "TeacherSurname";
                ws.Cells[1, 3].Value = "TeacherFather";
                ws.Cells[1, 4].Value = "BirthDate";
                ws.Cells[1, 5].Value = "Email";
                ws.Cells[1, 6].Value = "PhoneNumber";
                ws.Cells[1, 7].Value = "GenderID";
                ws.Cells[1, 8].Value = "ScientificNameID";
                ws.Cells[1, 9].Value = "ScientificDegreeID";
                ws.Cells[1, 10].Value = "DepartmentID";
                ws.Cells[1, 11].Value = "WorkTimeID";
                for (int i = 1; i <= 11; i++)
                {
                    ws.Column(i).AutoFit();
                }
                ep.Save();
            }
            MessageBox.Show($"Şablon yükləndi\n{dlg.FileName}");
            var message = MessageBox.Show("Faylı açmaq istəyirsinizmi?", "Şablon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = dlg.FileName,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }
        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Choose Excel Sheet(*.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var ep = new ExcelPackage(new FileInfo(dlg.FileName));
                var ws = ep.Workbook.Worksheets[0];
                for (int i = 2; i <= ws.Dimension.End.Row; i++)
                {
                    var importRow = new TeacherInfo();
                    importRow.ID = 0;
                    if (ws.Cells[i, 1].Value != null)
                        //importRow.TeacherName = ws.Cells[i, 1].Value.ToString();
                    if (ws.Cells[i, 2].Value != null)
                        //importRow.TeacherSurname = ws.Cells[i, 2].Value.ToString();
                    if (ws.Cells[i, 3].Value != null)
                        //importRow.TeacherFather = ws.Cells[i, 3].Value.ToString();
                    if (ws.Cells[i, 4].Value != null)
                        importRow.BirthDate = DateTime.Parse(ws.Cells[i, 4].Value.ToString());
                    else
                    {
                        MessageBox.Show("Tarixi daxil edin.", "Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                    if (ws.Cells[i, 5].Value != null)
                        importRow.Email = ws.Cells[i, 5].Value.ToString();
                    teacherInfoList.Add(importRow);
                }
                gridControl.DataSource = teacherInfoList;
                RefreshGrid();
                Refresh();
            }
        }
    }
}