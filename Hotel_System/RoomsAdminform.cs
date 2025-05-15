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
    public partial class RoomsAdminform : Form
    {
        public RoomsAdminform()
        {
            InitializeComponent();
        }

        private void addroomsbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomnumbertxt.Text) || string.IsNullOrWhiteSpace(roomtypetxt.Text) || string.IsNullOrWhiteSpace(pernighttxt.Text) || string.IsNullOrWhiteSpace(isavailabletxt.Text))
            {
                MessageBox.Show("Please Enter the details correctly","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            int Price = int.Parse(pernighttxt.Text);
            bool status = bool.Parse(isavailabletxt.Text);
            Rooms room = new Rooms(roomnumbertxt.Text,roomtypetxt.Text,Price,status);
            room.Add_Rooms(room);
            MessageBox.Show("Room Add Successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            roomnumbertxt.Clear();
            roomtypetxt.Clear();
            pernighttxt.Clear();
            isavailabletxt.Clear();
        }

        private void updateroombtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(roomidtxt.Text) || string.IsNullOrWhiteSpace(roomnumbertxt.Text) || string.IsNullOrWhiteSpace(roomtypetxt.Text) || string.IsNullOrWhiteSpace(pernighttxt.Text) || string.IsNullOrWhiteSpace(isavailabletxt.Text)){
                MessageBox.Show("Please enter the details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int roomid = int.Parse(roomidtxt.Text);
            int price = int.Parse(pernighttxt.Text);
            bool status = bool.Parse(isavailabletxt.Text);

            Rooms room = new Rooms(roomid, roomnumbertxt.Text, roomtypetxt.Text,price,status);
            room.edit_rooms(room);
            MessageBox.Show("Updated Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            roomidtxt.Clear();
            roomnumbertxt.Clear();
            roomtypetxt.Clear();
            pernighttxt.Clear();
            isavailabletxt.Clear();
        }

        private void deleteroombtn_Click(object sender, EventArgs e)
        {
            int roomid;
            if(!int.TryParse(roomidtxt.Text, out roomid))
            {
                MessageBox.Show("Please enter a valid Id","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Rooms room = new Rooms(roomid);
            bool isdelect = room.removeroom(room);
            if (isdelect)
            {
                MessageBox.Show("Deletion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roomidtxt.Clear();
            }
            else
            {
                MessageBox.Show("User not found or could not be deleted.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewallroomsbtn_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            dataGridView1.DataSource = rooms.LoadRooms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            if (string.IsNullOrWhiteSpace(roomtypetxt.Text))
            {
                MessageBox.Show("Please enter the room type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.TryParse(roomtypetxt.Text, out _)) // If it's a number, show error
            {
                MessageBox.Show("Room type should be a name, not a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.DataSource = room.Searchrooms(roomtypetxt.Text);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Hotel management System\Standard-Room-1350x750-2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
