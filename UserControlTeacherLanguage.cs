using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class UserControlTeacherLanguage : UserControl
    {
        TLDbContext db = new TLDbContext();
        public TeacherLanguage TeacherLanguages { get; set; } = new TeacherLanguage();
        public List<TeacherLanguage> TeacherLanguageList { get; set; } = new List<TeacherLanguage>();
        ITeacherLanguageServices _teacherLanguageServices;
        ILanguageServices _languageServices;
        public UserControlTeacherLanguage(TLDbContext db)
        {
            InitializeComponent();
            this.db = db;
            _teacherLanguageServices = new TeacherLanguageServices(new Repository<TeacherLanguage>(db));
            _languageServices = new LanguageServices(new Repository<Language>(db));
            layoutControl1.AutoScroll = false;
            languageCmb.Properties.DataSource = _languageServices.GetAllLanguages().ToList();
        }
        public UserControlTeacherLanguage(TLDbContext db, TeacherLanguage books)
        {
            this.db = db;
            TeacherLanguages = books;
            InitializeComponent();
            _teacherLanguageServices = new TeacherLanguageServices(new Repository<TeacherLanguage>(db));
            _languageServices = new LanguageServices(new Repository<Language>(db));
            languageCmb.Properties.DataSource = _languageServices.GetAllLanguages().ToList();
            layoutControl1.AutoScroll = false;
            LoadTeacherLanguages();
        }
        public void LoadTeacherLanguages()
        {
            if (TeacherLanguages != null)
            {
                preferenceTxt.Text= TeacherLanguages.PreferenceLevel.ToString();
                languageCmb.EditValue = TeacherLanguages.LanguageID;
            }
        }
            
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            if (TeacherLanguages.ID != 0)
            {
                _teacherLanguageServices.DeleteTeacherLanguage(TeacherLanguages.ID);
                TeacherLanguageList.Remove(TeacherLanguages);
            }
            else if (TeacherLanguages != null)
                TeacherLanguageList.Remove(TeacherLanguages);
        }

        private void languageCmb_EditValueChanged(object sender, EventArgs e)
        {
                TeacherLanguages.Language = languageCmb.GetSelectedDataRow() as Language;
        }

        private void preferenceTxt_EditValueChanged(object sender, EventArgs e)
        {
            TeacherLanguages.PreferenceLevel= Convert.ToInt32(preferenceTxt.Text);
        }
    }
}
