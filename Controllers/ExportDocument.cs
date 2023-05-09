using DevExpress.XtraGrid;
using System.Diagnostics;

namespace TeachingLoadInfoSystem.Controllers
{
    public class ExportDocument
    {
        private static readonly SaveFileDialog Save = new SaveFileDialog();
        public static void ToExcel(string fileName, GridControl gridControl)
        {
            Save.Filter = "Excel |*.xlsx";
            Save.FileName = fileName + "_" + DateTime.Now.ToString("dd_MM_yyyy");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                var options = new DevExpress.XtraPrinting.XlsxExportOptions();
                options.SheetName = "Sheet1";
                gridControl.ExportToXlsx(Save.FileName, options);
                MessageBox.Show($"Excel-ə export olundu\n{Save.FileName}");
                var message = MessageBox.Show("Faylı açmaq istəyirsinizmi?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Save.FileName,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }
            }
        }
        public static void ToWord(string fileName, GridControl gridControl)
        {
            Save.Filter = "Word |*.docx";
            Save.FileName = fileName + "_" + DateTime.Now.ToString("dd_MM_yyyy");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                gridControl.ExportToDocx(Save.FileName);
                MessageBox.Show($"Word-ə export olundu\n{Save.FileName}");
                var message = MessageBox.Show("Faylı açmaq istəyirsinizmi?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Save.FileName,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }
            }
        }
        public static void ToPDF(string fileName, GridControl gridControl)
        {
            Save.Filter = "PDF |*.pdf";
            Save.FileName = fileName + "_" + DateTime.Now.ToString("dd_MM_yyyy");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                gridControl.ExportToPdf(Save.FileName);
                MessageBox.Show($"PDF-ə export olundu\n{Save.FileName}");
                var message = MessageBox.Show("Faylı açmaq istəyirsinizmi?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Save.FileName,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }
            }
        }
        public static void ToHTML(string fileName, GridControl gridControl)
        {
            Save.Filter = "HTML |*.html";
            Save.FileName = fileName + "_" + DateTime.Now.ToString("dd_MM_yyyy");
            if (Save.ShowDialog() == DialogResult.OK)
            {
                gridControl.ExportToHtml(Save.FileName);
                MessageBox.Show($"HTML-ə export olundu\n{Save.FileName}");
                var message = MessageBox.Show("Faylı açmaq istəyirsinizmi?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Save.FileName,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }
            }
        }
    }
}
