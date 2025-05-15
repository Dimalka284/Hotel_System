using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string name = usernametxt.Text;
            string password = passwordtxt.Text;

            User user = new User();
            if (user.Validlogin(name, password))
            {
                MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminMainForm panel = new AdminMainForm();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Hotel management System\hotel_image.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional for scaling
        }
    }
}
