namespace UIS
{
    partial class frm_mainmenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainmenu));
            pnl_menucontainer = new Panel();
            llbl_loginlink = new LinkLabel();
            btn_signup = new Button();
            cbo_gender = new ComboBox();
            txt_pw = new TextBox();
            txt_dob = new TextBox();
            txt_age = new TextBox();
            txt_email = new TextBox();
            txt_name = new TextBox();
            lbl_pw = new Label();
            lbl__age = new Label();
            lbl_gender = new Label();
            lbl_birthday = new Label();
            lbl_email = new Label();
            lbl_name = new Label();
            lbl_Welcome = new Label();
            pnl_menucontainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_menucontainer
            // 
            pnl_menucontainer.BackColor = Color.FromArgb(87, 111, 141);
            pnl_menucontainer.BorderStyle = BorderStyle.Fixed3D;
            pnl_menucontainer.Controls.Add(llbl_loginlink);
            pnl_menucontainer.Controls.Add(btn_signup);
            pnl_menucontainer.Controls.Add(cbo_gender);
            pnl_menucontainer.Controls.Add(txt_pw);
            pnl_menucontainer.Controls.Add(txt_dob);
            pnl_menucontainer.Controls.Add(txt_age);
            pnl_menucontainer.Controls.Add(txt_email);
            pnl_menucontainer.Controls.Add(txt_name);
            pnl_menucontainer.Controls.Add(lbl_pw);
            pnl_menucontainer.Controls.Add(lbl__age);
            pnl_menucontainer.Controls.Add(lbl_gender);
            pnl_menucontainer.Controls.Add(lbl_birthday);
            pnl_menucontainer.Controls.Add(lbl_email);
            pnl_menucontainer.Controls.Add(lbl_name);
            pnl_menucontainer.Controls.Add(lbl_Welcome);
            pnl_menucontainer.Location = new Point(48, 73);
            pnl_menucontainer.Name = "pnl_menucontainer";
            pnl_menucontainer.Size = new Size(450, 500);
            pnl_menucontainer.TabIndex = 0;
            pnl_menucontainer.Paint += panel1_Paint;
            // 
            // llbl_loginlink
            // 
            llbl_loginlink.AutoSize = true;
            llbl_loginlink.Font = new Font("Calisto MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llbl_loginlink.Location = new Point(113, 446);
            llbl_loginlink.Name = "llbl_loginlink";
            llbl_loginlink.Size = new Size(216, 23);
            llbl_loginlink.TabIndex = 14;
            llbl_loginlink.TabStop = true;
            llbl_loginlink.Text = "Already have an account?";
            llbl_loginlink.LinkClicked += llbl_loginlink_LinkClicked;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(109, 109, 109);
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signup.ForeColor = Color.MistyRose;
            btn_signup.Location = new Point(166, 404);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(113, 29);
            btn_signup.TabIndex = 13;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // cbo_gender
            // 
            cbo_gender.BackColor = Color.MistyRose;
            cbo_gender.FormattingEnabled = true;
            cbo_gender.ItemHeight = 20;
            cbo_gender.Items.AddRange(new object[] { "Male", "Female", "Lesbian", "Gay", "Bisexual", "Transgender", "Queer", "++" });
            cbo_gender.Location = new Point(291, 189);
            cbo_gender.Name = "cbo_gender";
            cbo_gender.Size = new Size(120, 28);
            cbo_gender.TabIndex = 12;
            // 
            // txt_pw
            // 
            txt_pw.BackColor = Color.MistyRose;
            txt_pw.BorderStyle = BorderStyle.None;
            txt_pw.Font = new Font("Segoe UI", 10F);
            txt_pw.Location = new Point(36, 357);
            txt_pw.Multiline = true;
            txt_pw.Name = "txt_pw";
            txt_pw.PasswordChar = '*';
            txt_pw.Size = new Size(250, 27);
            txt_pw.TabIndex = 11;
            // 
            // txt_dob
            // 
            txt_dob.BackColor = Color.MistyRose;
            txt_dob.BorderStyle = BorderStyle.None;
            txt_dob.Font = new Font("Segoe UI", 10F);
            txt_dob.Location = new Point(35, 273);
            txt_dob.Multiline = true;
            txt_dob.Name = "txt_dob";
            txt_dob.Size = new Size(250, 27);
            txt_dob.TabIndex = 10;
            // 
            // txt_age
            // 
            txt_age.BackColor = Color.MistyRose;
            txt_age.BorderStyle = BorderStyle.None;
            txt_age.Font = new Font("Segoe UI", 10F);
            txt_age.Location = new Point(293, 108);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(82, 23);
            txt_age.TabIndex = 9;
            txt_age.TextChanged += textBox2_TextChanged;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.MistyRose;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(34, 190);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(250, 27);
            txt_email.TabIndex = 8;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.MistyRose;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 10F);
            txt_name.Location = new Point(36, 108);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(248, 27);
            txt_name.TabIndex = 7;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // lbl_pw
            // 
            lbl_pw.AutoSize = true;
            lbl_pw.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pw.ForeColor = Color.MistyRose;
            lbl_pw.Location = new Point(35, 319);
            lbl_pw.Name = "lbl_pw";
            lbl_pw.Size = new Size(110, 26);
            lbl_pw.TabIndex = 6;
            lbl_pw.Text = "Password:";
            // 
            // lbl__age
            // 
            lbl__age.AutoSize = true;
            lbl__age.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl__age.ForeColor = Color.MistyRose;
            lbl__age.Location = new Point(293, 65);
            lbl__age.Name = "lbl__age";
            lbl__age.Size = new Size(58, 26);
            lbl__age.TabIndex = 5;
            lbl__age.Text = "Age:";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gender.ForeColor = Color.MistyRose;
            lbl_gender.Location = new Point(293, 150);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(92, 26);
            lbl_gender.TabIndex = 4;
            lbl_gender.Text = "Gender:";
            // 
            // lbl_birthday
            // 
            lbl_birthday.AutoSize = true;
            lbl_birthday.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_birthday.ForeColor = Color.MistyRose;
            lbl_birthday.Location = new Point(35, 231);
            lbl_birthday.Name = "lbl_birthday";
            lbl_birthday.Size = new Size(270, 26);
            lbl_birthday.TabIndex = 3;
            lbl_birthday.Text = "Date of Birth:(dd/mm/yy)";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = Color.MistyRose;
            lbl_email.Location = new Point(35, 150);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(75, 26);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.MistyRose;
            lbl_name.Location = new Point(35, 65);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(78, 26);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Name:";
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.BackColor = Color.Transparent;
            lbl_Welcome.FlatStyle = FlatStyle.Popup;
            lbl_Welcome.Font = new Font("Vivaldi", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Welcome.ForeColor = Color.MistyRose;
            lbl_Welcome.ImageAlign = ContentAlignment.TopCenter;
            lbl_Welcome.Location = new Point(129, 10);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(176, 55);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Sign up";
            lbl_Welcome.Click += lbl_Welcome_Click;
            // 
            // frm_mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(pnl_menucontainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_mainmenu";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            pnl_menucontainer.ResumeLayout(false);
            pnl_menucontainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menucontainer;
        private Label lbl_Welcome;
        private Label lbl__age;
        private Label lbl_gender;
        private Label lbl_birthday;
        private Label lbl_email;
        private Label lbl_name;
        private Label lbl_pw;
        private TextBox txt_dob;
        private TextBox txt_age;
        private TextBox txt_email;
        private TextBox txt_name;
        private ComboBox cbo_gender;
        private TextBox txt_pw;
        private Button btn_signup;
        private LinkLabel llbl_loginlink;
    }
}
