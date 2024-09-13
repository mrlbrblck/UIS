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
            // Collect inputs from textboxes (assuming you have textboxes named txtUsername, txtEmail, etc.)
            //string username = txtUsername.Text;
            //string email = txtEmail.Text;
            //string password = txtPassword.Text;

            // Create the CSV line (separated by commas)
            //string csvLine = $"{username},{email},{password}";

            // Specify the path to save the file
            //string filePath = @"C:\path\to\your\file\signup_data.txt";

            // Append the user data to the file
            //using (StreamWriter writer = new StreamWriter(filePath, true)) // true to append data
            //{
            //    writer.WriteLine(csvLine);
            //}

            // Show confirmation message
            MessageBox.Show("Sign up successful!");
        }


        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
