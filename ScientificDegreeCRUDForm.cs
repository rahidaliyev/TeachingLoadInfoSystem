using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class ScientificDegreeCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        ScientificDegree worktime = new ScientificDegree();
        TLDbContext db = new TLDbContext();
        IScientificDegreeServices _workTimeServices { get; set; }
        public ScientificDegreeCRUDForm(ScientificDegree worktime,IScientificDegreeServices services)
        {
            InitializeComponent();
            _workTimeServices = new ScientificDegreeServices(new Repository<ScientificDegree>(db));
            this.worktime = worktime;
            this._workTimeServices= services;
            LoadData();
        }
        public void InsertData()
        {
            worktime.DegreeCode = departmentCodeTxt.Text;
            worktime.DegreeName= departmentNameTxt.Text;
        }
        public void LoadData()
        {
            departmentCodeTxt.Text = worktime.DegreeCode;
            departmentNameTxt.Text = worktime.DegreeName;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (worktime.ID != 0)
            {
                try
                {
                    this._workTimeServices.UpdateScientificDegree(worktime);
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
                    this._workTimeServices.InsertScientificDegree(worktime);

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
