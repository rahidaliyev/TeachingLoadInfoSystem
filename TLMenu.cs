using DevExpress.XtraBars;

namespace TeachingLoadInfoSystem
{
    public partial class TLMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Models.User user = new Models.User();
        public TLMenu(Models.User user)
        {
            InitializeComponent();
            this.user = user;
            usernameTxt.Caption = $" Xoş gəlmisiniz {user.UserName}!";
        }
        private void newTabbedForm(Form frm, string titleName)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == titleName)
                {
                    IsOpen = true;
                    f.Focus(); break;
                }
            }
            if (IsOpen == false)
            {
                frm.MdiParent = TLMenu.ActiveForm;
                frm.Text = titleName;
                frm.Show();
            }
        }

        private void subjectAccBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new SubjectGridForm(), "Fənn");
        }

    

        private void teacherInfoAccBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new TeacherInfoGridForm(), "Müəllim haqqında");
        }

    

        private void departmentAccBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new DepartmentGridForm(), "Kafedra");
        }

   
    
        private void exitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void includedBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new IncludedEducationPlanGridForm(), "Kafedraya daxil olan yük");
        }

        private void excludedBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new ExcludedEducationPlanGridForm(), "Kafedradan çıxan yük");
        }

        private void teachingLoadBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new TeachingLoadCRUDForm(), "Sorğu");
        }

        private void specialityBtn_Click(object sender, EventArgs e)
        {
            newTabbedForm(new EducationPlanGridForm(), "Tədris planı");
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            newTabbedForm(new JoinForGroupAndEducationPlanForm(), "sadas");
        }
    }
}