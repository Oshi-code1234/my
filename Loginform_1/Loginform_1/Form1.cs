namespace Loginform_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "admin" && tb_password.Text == "123")
            {

                Homepage hp = new Homepage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Message box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
