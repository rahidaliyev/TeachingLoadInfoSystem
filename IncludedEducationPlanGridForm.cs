using System.Data;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class IncludedEducationPlanGridForm : DevExpress.XtraEditors.XtraForm
    {
        IEducationPlanServices _educationPlanServices { get; set; }
        public IncludedEducationPlanGridForm()
        {
            InitializeComponent();
            _educationPlanServices = new EducationPlanServices(new Repository<EducationPlan>(new AppDbContext.TLDbContext()));
        }
        private void backBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Visible = false;

            speciality1Btn.Visible = true;
            speciality2Btn.Visible = true;
            speciality3Btn.Visible = true;
            speciality4Btn.Visible = true;
            speciality5Btn.Visible = true;
        }

        private void speciality1Btn_Click_1(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "050509").ToList();
        }

        private void speciality2Btn_Click(object sender, EventArgs e)
        {

        }

        private void speciality3Btn_Click_1(object sender, EventArgs e)
        {

        }

        private void speciality4Btn_Click_1(object sender, EventArgs e)
        {

        }

        private void speciality5Btn_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
