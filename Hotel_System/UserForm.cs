using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text) || string.IsNullOrWhiteSpace (roletxt.Text))
            {
                MessageBox.Show("Please enter the details correctly","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User(usernametxt.Text,passwordtxt.Text,roletxt.Text);
            user.Adduser(user);
            MessageBox.Show("Registration Successful!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            usernametxt.Clear();
            passwordtxt.Clear();
            roletxt.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int userid;
            if(!int.TryParse(useridtxt.Text,out userid))
            {
                MessageBox.Show("Invalid UserId.Please enter a valid ID","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            User user = new User(userid);
            bool isdelect = user.Deleteuser(user);
            if (isdelect)
            {
                MessageBox.Show("Deletion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                useridtxt.Clear();
            }
            else
            {
                MessageBox.Show("User not found or could not be deleted.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(useridtxt.Text) ||string.IsNullOrWhiteSpace(usernametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text) || string.IsNullOrWhiteSpace(roletxt.Text))
            {
                MessageBox.Show("Please enter the details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int Userid = int.Parse(useridtxt.Text);
            User user = new User(Userid, usernametxt.Text, passwordtxt.Text, roletxt.Text);
            user.UpdateUser(user);

            MessageBox.Show("Updated Successful!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            useridtxt.Clear();
            usernametxt.Clear();
            passwordtxt.Clear();
            roletxt.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminMainForm admin = new AdminMainForm();
            admin.Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (string.IsNullOrWhiteSpace(useridtxt.Text))
            {
                dataGridView2.DataSource = user.LoadAllUser();
            }
            else
            {
                if(int.TryParse(useridtxt.Text,out int userid))
                {
                    dataGridView2.DataSource = user.SearchUser(userid);
                }
                else
                {
                    MessageBox.Show("Please enter a valid User id");
                }
            }
            
        }
    }
}
