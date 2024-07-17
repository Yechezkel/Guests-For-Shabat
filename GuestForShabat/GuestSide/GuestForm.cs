using GuestForShabat.DAL;
using GuestForShabat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestForShabat.GuestSide
{
    public partial class GuestForm : Form
    {
        DBContext dbContext = new DBContext();
        public GuestForm()
        {
            InitializeComponent();
            LoadGuests();
        }

        private void LoadGuests()
        {
            listBox_guests.Items.Clear();
            DataTable dataTable = dbContext.MakeQueryDT("select GuestName from Guests;");
            foreach (DataRow row in dataTable.Rows)
            {
                listBox_guests.Items.Add(row["GuestName"].ToString().Trim());
            }
        }

        private void OnButtonAddGuestClick(object sender, EventArgs e)
        {
            string newGuest = textBox_guestName.Text.Trim();

            if (string.IsNullOrEmpty(newGuest))
            {
                MessageBox.Show("נא להכניס שם אורח");
                return;
            }
            SqlParameter[] sp = { new SqlParameter("@newGuest", newGuest) };
            DataTable dataTable = dbContext.MakeQueryDT(@"BEGIN TRY
                                                              BEGIN TRANSACTION;
                                                                  insert into Guests(GuestName) values (@newGuest);
                                                                  SELECT 1 as result;
                                                              COMMIT TRANSACTION;
                                                          END TRY
                                                          BEGIN CATCH        
                                                              ROLLBACK TRANSACTION;  
                                                              SELECT 0 as result;  
                                                          END CATCH;", sp);


            if (dataTable.Rows[0]["result"].ToString() == "0")
                MessageBox.Show("לא ניתן להוסיף, שם אורח קיים כבר");
            if (dataTable.Rows[0]["result"].ToString() == "1")
            {
                //textBox_guestName.Clear();
                LoadGuests();
            }
                
        }

        private void listBox_guests_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            textBox_guestName.Text = listBox.SelectedItem.ToString();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            string guestName = textBox_guestName.Text.Trim();
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("אנא הכנס שם אורח");
                return;
            }
            //SqlParameter[] sp = { new SqlParameter("@GuestName", guestName) };
            DataTable dataTable = dbContext.MakeQueryDT("select GuestId from Guests where GuestName = N'" + guestName + "';");
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("אורח לא קיים, יש להוסיף אורח לרשימת האורחים תחילה");
                return;
            }
            int guestID = int.Parse(dataTable.Rows[0]["GuestId"].ToString());
            Navigator.MoveToNextCategoryForm(guestID, -1);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!Navigator.isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
