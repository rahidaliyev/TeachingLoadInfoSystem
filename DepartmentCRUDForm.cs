using System;
using System.Windows.Forms;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1
{
    public partial class DepartmentCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        Department department = new Department();
        TLDbContext db = new TLDbContext();
        IDepartmentServices _departmanetServices { get; set; }
        public DepartmentCRUDForm(Department department,TLDbContext context,IDepartmentServices services)
        {
            InitializeComponent();
            _departmanetServices = new DepartmentServices(new Repository<Department>(db));
            this.department = department;
            db = context;
            this._departmanetServices= services;
            LoadData();
        }
        public void InsertData()
        {
            department.DepartmentCode = departmentCodeTxt.Text;
            department.DepartmentName = departmentNameTxt.Text;
        }
        public void LoadData()
        {
            departmentCodeTxt.Text = department.DepartmentCode;
            departmentNameTxt.Text = department.DepartmentName;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (department.ID != 0)
            {
                try
                {
                    this._departmanetServices.UpdateDepartment(department);
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
                    this._departmanetServices.InsertDepartment(department);

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
