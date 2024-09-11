namespace UIS
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            pnl_login = new Panel();
            pnl_header = new Panel();
            pnl_loginmenu = new Panel();
            lbl_login = new Label();
            txt_loginemail = new TextBox();
            txt_loginpw = new TextBox();
            lbl_loginemail = new Label();
            lbl_loginpw = new Label();
            btn_signup = new Button();
            pnl_login.SuspendLayout();
            pnl_header.SuspendLayout();
            pnl_loginmenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_login
            // 
            pnl_login.BackColor = Color.FromArgb(123, 57, 78);
            pnl_login.Controls.Add(pnl_header);
            pnl_login.Controls.Add(pnl_loginmenu);
            pnl_login.Location = new Point(151, 73);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(700, 500);
            pnl_login.TabIndex = 0;
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.Transparent;
            pnl_header.Controls.Add(lbl_login);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(700, 141);
            pnl_header.TabIndex = 0;
            // 
            // pnl_loginmenu
            // 
            pnl_loginmenu.CausesValidation = false;
            pnl_loginmenu.Controls.Add(btn_signup);
            pnl_loginmenu.Controls.Add(lbl_loginpw);
            pnl_loginmenu.Controls.Add(lbl_loginemail);
            pnl_loginmenu.Controls.Add(txt_loginpw);
            pnl_loginmenu.Controls.Add(txt_loginemail);
            pnl_loginmenu.Dock = DockStyle.Bottom;
            pnl_loginmenu.Location = new Point(0, 147);
            pnl_loginmenu.Name = "pnl_loginmenu";
            pnl_loginmenu.Size = new Size(700, 353);
            pnl_loginmenu.TabIndex = 1;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Vivaldi", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.MistyRose;
            lbl_login.Location = new Point(293, 45);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(132, 55);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            // 
            // txt_loginemail
            // 
            txt_loginemail.BackColor = Color.MistyRose;
            txt_loginemail.Location = new Point(153, 82);
            txt_loginemail.Multiline = true;
            txt_loginemail.Name = "txt_loginemail";
            txt_loginemail.Size = new Size(416, 37);
            txt_loginemail.TabIndex = 0;
            // 
            // txt_loginpw
            // 
            txt_loginpw.BackColor = Color.MistyRose;
            txt_loginpw.Location = new Point(153, 186);
            txt_loginpw.Multiline = true;
            txt_loginpw.Name = "txt_loginpw";
            txt_loginpw.PasswordChar = '*';
            txt_loginpw.Size = new Size(416, 37);
            txt_loginpw.TabIndex = 1;
            // 
            // lbl_loginemail
            // 
            lbl_loginemail.AutoSize = true;
            lbl_loginemail.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_loginemail.ForeColor = Color.MistyRose;
            lbl_loginemail.Location = new Point(301, 29);
            lbl_loginemail.Name = "lbl_loginemail";
            lbl_loginemail.Size = new Size(121, 39);
            lbl_loginemail.TabIndex = 1;
            lbl_loginemail.Text = "Email:";
            lbl_loginemail.Click += lbl_loginemail_Click;
            // 
            // lbl_loginpw
            // 
            lbl_loginpw.AutoSize = true;
            lbl_loginpw.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_loginpw.ForeColor = Color.MistyRose;
            lbl_loginpw.Location = new Point(275, 133);
            lbl_loginpw.Name = "lbl_loginpw";
            lbl_loginpw.Size = new Size(172, 39);
            lbl_loginpw.TabIndex = 2;
            lbl_loginpw.Text = "Password:";
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(109, 109, 109);
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signup.ForeColor = Color.MistyRose;
            btn_signup.Location = new Point(289, 253);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(144, 46);
            btn_signup.TabIndex = 14;
            btn_signup.Text = "Login";
            btn_signup.UseVisualStyleBackColor = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(pnl_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnl_login.ResumeLayout(false);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            pnl_loginmenu.ResumeLayout(false);
            pnl_loginmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_login;
        private Panel pnl_header;
        private Panel pnl_loginmenu;
        private Label lbl_login;
        private TextBox txt_loginpw;
        private TextBox txt_loginemail;
        private Label lbl_loginemail;
        private Label lbl_loginpw;
        private Button btn_signup;
    }
}