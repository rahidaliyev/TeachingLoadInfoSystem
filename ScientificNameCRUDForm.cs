using System;
using System.Windows.Forms;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class ScientificNameCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        ScientificName scientificName = new ScientificName();
        TLDbContext db = new TLDbContext();
        IScientificNameServices _departmanetServices { get; set; }
        public ScientificNameCRUDForm(ScientificName scientificName,TLDbContext context,IScientificNameServices services)
        {
            InitializeComponent();
            _departmanetServices = new ScientificNameServices(new Repository<ScientificName>(db));
            this.scientificName = scientificName;
            db = context;
            this._departmanetServices= services;
            LoadData();
        }
        public void InsertData()
        {
            scientificName.Code= scientificNameCodeTxt.Text;
            scientificName.Name= scientificNameTxt.Text;
        }
        public void LoadData()
        {
            scientificNameCodeTxt.Text = scientificName.Code;
            scientificNameTxt.Text = scientificName.Name;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (scientificName.ID != 0)
            {
                try
                {
                    this._departmanetServices.UpdateScientificName(scientificName);
                    MessageBox.Show("Məlumat yeniləndi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    this._departmanetServices.InsertScientificName(scientificName);

                    MessageBox.Show("Yeni məlumat əlavə edildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
