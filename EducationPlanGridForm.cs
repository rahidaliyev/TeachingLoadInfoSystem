using System.Data;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace TeachingLoadInfoSystem
{
    public partial class EducationPlanGridForm : DevExpress.XtraEditors.XtraForm
    {
        IEducationPlanServices _educationPlanServices { get; set; }
        public EducationPlanGridForm()
        {
            InitializeComponent();
            _educationPlanServices = new EducationPlanServices(new Repository<EducationPlan>(new AppDbContext.TLDbContext()));
        }

        private void speciality1Btn_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "050509").ToList();
        }

        private void specaility2Btn_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "xxxxx").ToList();
        }

        private void speciality3Btn_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "xxxxx").ToList();
        }

        private void speciality4Btn_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "xxxxx").ToList();
        }

        private void speciality5Btn_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            gridControl1.DataSource = _educationPlanServices.GetAllEducationPlans().Where(x => x.SpecialityCode == "xxxxx").ToList();
        }

        private void backBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Visible = false;

            speciality1Btn.Visible = true;
            speciality2Btn.Visible = true;
            speciality3Btn.Visible = true;
            speciality4Btn.Visible = true;
            speciality5Btn.Visible = true;
        }
    }
}
