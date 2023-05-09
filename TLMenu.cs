﻿using DevExpress.XtraBars;

namespace TeachingLoadInfoSystem
{
    public partial class TLMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TLMenu()
        {
            InitializeComponent();
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

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            newTabbedForm(new TeacherInfoGridForm(), "Müəllim haqqında");
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            newTabbedForm(new WorkTimeGridForm(), "Ştat");
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            newTabbedForm(new DepartmentGridForm(), "Kafedra");
        }
    }
}