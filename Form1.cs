namespace UIS

{
    public partial class frm_mainmenu : Form
    {
        public frm_mainmenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void llbl_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login loginscreen = new frm_login();
            loginscreen.Show();
            this.Hide();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
