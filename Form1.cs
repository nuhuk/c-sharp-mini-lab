using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AppBuilding
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Text = usernameInputBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordInputBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = passwordInputBox.Text;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameInputBox.Text == string.Empty && passwordInputBox.Text == string.Empty)
            {
                MessageBox.Show("login unccessful!");
            }
            else
            {
                MessageBox.Show("Hello " + usernameInputBox.Text + " You've successfully logged in!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
