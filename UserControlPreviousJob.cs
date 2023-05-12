using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class UserControlPreviousJob : UserControl
    {
        TLDbContext db = new TLDbContext();
        public PreviousJob PreviousJobs { get; set; } = new PreviousJob();
        public List<PreviousJob> PreviousJobList { get; set; } = new List<PreviousJob>();
        IPreviousJobServices _teacherLanguageServices;
        public UserControlPreviousJob(TLDbContext db)
        {
            InitializeComponent();
            this.db = db;
            _teacherLanguageServices = new PreviousJobServices(new Repository<PreviousJob>(db));
            //layoutControl1.AutoScroll = false;
        }
        public UserControlPreviousJob(TLDbContext db, PreviousJob books)
        {
            this.db = db;
            PreviousJobs = books;
            InitializeComponent();
            _teacherLanguageServices = new PreviousJobServices(new Repository<PreviousJob>(db));
            //layoutControl1.AutoScroll = false;
            LoadPreviousJobs();
        }
        public void LoadPreviousJobs()
        {
            if (PreviousJobs != null)
            {
                jobNameTxt.Text= PreviousJobs.JobName.ToString();
                fromDate.Text = PreviousJobs.StartDate.ToString("MM-dd-yyyy");
                toDate.Text = PreviousJobs.EndDate.ToString("MM-dd-yyyy");
            }
        }
            
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            if (PreviousJobs.ID != 0)
            {
                _teacherLanguageServices.DeletePreviousJob(PreviousJobs.ID);
                PreviousJobList.Remove(PreviousJobs);
            }
            else if (PreviousJobs != null)
                PreviousJobList.Remove(PreviousJobs);
        }

        private void jobNameTxt_TextChanged(object sender, EventArgs e)
        {
            PreviousJobs.JobName = jobNameTxt.Text; 
        }

        private void fromDate_EditValueChanged(object sender, EventArgs e)
        {
            PreviousJobs.StartDate = DateTime.ParseExact(fromDate.Text, "dd-MM-yyyy", null);
        }

        private void toDate_EditValueChanged(object sender, EventArgs e)
        {
            PreviousJobs.EndDate = DateTime.ParseExact(toDate.Text, "dd-MM-yyyy", null);
        }
    }
}
