using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1
{
    public partial class WorkTimeCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        WorkTime worktime = new WorkTime();
        TLDbContext db = new TLDbContext();
        IWorkTimeServices _workTimeServices { get; set; }
        public WorkTimeCRUDForm(WorkTime worktime,IWorkTimeServices services)
        {
            InitializeComponent();
            _workTimeServices = new WorkTimeServices(new Repository<WorkTime>(db));
            this.worktime = worktime;
            this._workTimeServices= services;
            LoadData();
        }
        public void InsertData()
        {
            worktime.WorkTimeCode = departmentCodeTxt.Text;
            worktime.WorkTimeName = departmentNameTxt.Text;
        }
        public void LoadData()
        {
            departmentCodeTxt.Text = worktime.WorkTimeCode;
            departmentNameTxt.Text = worktime.WorkTimeName;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (worktime.ID != 0)
            {
                try
                {
                    this._workTimeServices.UpdateWorkTime(worktime);
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
                    this._workTimeServices.InsertWorkTime(worktime);

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
