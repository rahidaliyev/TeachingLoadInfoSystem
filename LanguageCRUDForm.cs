using System;
using System.Windows.Forms;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class LanguageCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        Language language = new Language();
        TLDbContext db = new TLDbContext();
        ILanguageServices _departmanetServices { get; set; }
        public LanguageCRUDForm(Language language,TLDbContext context,ILanguageServices services)
        {
            InitializeComponent();
            _departmanetServices = new LanguageServices(new Repository<Language>(db));
            this.language = language;
            db = context;
            this._departmanetServices= services;
            LoadData();
        }
        public void InsertData()
        {
            language.LanguageCode = languageCodeTxt.Text;
            language.LanguageName = languageNameTxt.Text;
        }
        public void LoadData()
        {
            languageCodeTxt.Text = language.LanguageCode;
            languageNameTxt.Text = language.LanguageName;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (language.ID != 0)
            {
                try
                {
                    this._departmanetServices.UpdateLanguage(language);
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
                    this._departmanetServices.InsertLanguage(language);

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
