namespace TeachingLoadInfoSystem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.exitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.usernameTxt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeachingLoadInfoSystem.Properties.Resources.elm_tehsil_naziriyi_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TeachingLoadInfoSystem.Properties.Resources.UNEC_logo_yeni_2020_11;
            this.pictureBox2.Location = new System.Drawing.Point(1060, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 127);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tədris Yükünün Paylanması Avtomatlaşdırılmış İnformasiya Sistemi";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.exitBtn);
            this.groupControl1.Controls.Add(this.loginBtn);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.passwordTxt);
            this.groupControl1.Controls.Add(this.usernameTxt);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(419, 285);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(589, 286);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Sistemə Giriş";
            // 
            // exitBtn
            // 
            this.exitBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.exitBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Appearance.Options.UseBackColor = true;
            this.exitBtn.Appearance.Options.UseFont = true;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Location = new System.Drawing.Point(307, 227);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(154, 42);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Çıxış";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.loginBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Appearance.Options.UseBackColor = true;
            this.loginBtn.Appearance.Options.UseFont = true;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Location = new System.Drawing.Point(147, 227);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(154, 42);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Daxil ol";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifrə";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "İstifadəçi adı";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(226, 159);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.Properties.Appearance.Options.UseFont = true;
            this.passwordTxt.Size = new System.Drawing.Size(276, 36);
            this.passwordTxt.TabIndex = 1;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(226, 85);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxt.Properties.Appearance.Options.UseFont = true;
            this.usernameTxt.Size = new System.Drawing.Size(276, 36);
            this.usernameTxt.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 687);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Label label3;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.TextEdit usernameTxt;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
        private DevExpress.XtraEditors.SimpleButton exitBtn;
    }
}