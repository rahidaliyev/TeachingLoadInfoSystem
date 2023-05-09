using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.IO;
using System.Text;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services.Interfaces;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem.Controllers
{
    public class LayoutController
    {
        private ILayoutServices _layoutServices { get; set; }
        public static void RestoreLayout(int UserID, string GridName, string FormName, GridControl gridControl, LayoutInfo layoutInfo)
        {
            ILayoutServices _layoutServices = new LayoutServices(new Repository<LayoutInfo>(new TLDbContext()));
            layoutInfo = _layoutServices.GetLayoutByUserIDGridNameFormName(UserID, GridName, FormName);
            if (layoutInfo == null)
            {
                layoutInfo = new LayoutInfo();
            }
            else
            {
                if (layoutInfo.UserID == UserID && layoutInfo.GridName == GridName && layoutInfo.FormName == FormName)
                {
                    byte[] byteArray = Encoding.Unicode.GetBytes(layoutInfo.Stream);
                    MemoryStream stream = new MemoryStream(byteArray);
                    gridControl.MainView.RestoreLayoutFromStream(stream);
                }
            }
        }
        public static void SaveLayout(int UserID, string GridName, string FormName, GridView gridView, LayoutInfo layoutInfo)
        {
            ILayoutServices _layoutServices = new LayoutServices(new Repository<LayoutInfo>(new TLDbContext()));
            layoutInfo = _layoutServices.GetLayoutByUserIDGridNameFormName(UserID, GridName, FormName);
            if (layoutInfo == null)
                layoutInfo = new LayoutInfo();
            MemoryStream stream = new MemoryStream();
            gridView.SaveLayoutToStream(stream);
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            string STREAM = reader.ReadToEnd();
            layoutInfo.UserID = UserID;
            layoutInfo.GridName = GridName;
            layoutInfo.FormName = FormName;
            layoutInfo.Stream = STREAM;
            if (layoutInfo.ID != 0)
            {
                _layoutServices.UpdateLayout(layoutInfo);
                MessageBox.Show("Mövcud şablon yeniləndi.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _layoutServices.InsertLayout(layoutInfo);
                MessageBox.Show("Yeni şablon yaradıldı.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}