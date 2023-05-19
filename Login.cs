using DevExpress.XtraReports.UserDesigner.Native;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Models.User user = new Models.User();
        private IUserServices _userServices { get; set; }
        public Login()
        {
            InitializeComponent();
            _userServices = new UserServices(new Repository<Models.User>(new TLDbContext()));
            passwordTxt.Properties.PasswordChar = '*';
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {   
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user = _userServices.GetAllUsers().FirstOrDefault(x => x.UserName == usernameTxt.Text && x.UserPassword == passwordTxt.Text);
            if (user == null)
            {
                MessageBox.Show("İstifadəçi adı və ya şifrəsi yalnışdır!", "Yalnış şifrə", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TLMenu frm= new TLMenu(user);
                if (frm.ShowDialog() != DialogResult.OK)
                    Application.Exit();
                else
                    this.Show();
                passwordTxt.Text = "";
            }
        }
    }
}
