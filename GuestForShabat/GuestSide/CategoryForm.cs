using GuestForShabat.DAL;
using GuestForShabat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestForShabat.GuestSide
{
    public partial class CategoryForm : Form
    {
        DBContext dbContext = new DBContext(); 
        
        int guestID;
        int categoryID;
        int index;
        public CategoryForm(int guestID, int categoryID, int index)
        {
            InitializeComponent();
            this.guestID = guestID;
            this.categoryID = categoryID;
            this.index = index;

            LoadOthersFood();
            LoadMyFood();

            label_category.Text = GetCategoryName();



        }

        private void OnButtonAddFoodClick(object sender, EventArgs e)
        {
            string foodName = textBox_food.Text.Trim();
            textBox_food.Clear();
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("נא להכניס תבשיל");
                return;
            }
            SqlParameter[] sp = { new SqlParameter("@CategoryID", categoryID), new SqlParameter("@GuestID", guestID), new SqlParameter("@FoodName", foodName) };
            DataTable dataTable = dbContext.MakeQueryDT(@"BEGIN TRY
                                                             BEGIN TRANSACTION;
                                                                insert into Orders(CategoryID,GuestID,FoodName ) values(@CategoryID,@GuestID,@FoodName);
                                                                SELECT 1 as result;
                                                                COMMIT TRANSACTION;
                                                          END TRY
                                                          BEGIN CATCH
                                                                ROLLBACK TRANSACTION;
                                                                SELECT 0 as result;
                                                            END CATCH; ", sp);

            if (dataTable.Rows[0]["result"].ToString() == "0")
                MessageBox.Show("כבר בחרת בתבשיל זה");
            if (dataTable.Rows[0]["result"].ToString() == "1")
                LoadMyFood();
        }

        private void LoadOthersFood()
        {
            listView_othersFood.Clear();
            SqlParameter[] sp = { new SqlParameter("@GuestID", guestID) ,new SqlParameter("@CategoryID", categoryID) };
            DataTable dataTable = dbContext.MakeQueryDT(@"select distinct FoodName 
                                                        from Orders 
                                                        where GuestID != @GuestID
                                                        and CategoryID = @CategoryID;", sp);
            foreach (DataRow row in dataTable.Rows)
            {
               listView_othersFood.Items.Add(row["FoodName"].ToString().Trim());
            }
        }

        private void LoadMyFood()
        {
            listView_myFood.Clear();
            SqlParameter[] sp = { new SqlParameter("@GuestID", guestID) , new SqlParameter("@CategoryID", categoryID) };
            DataTable dataTable = dbContext.MakeQueryDT(@"select distinct FoodName 
                                                        from Orders 
                                                        where GuestID = @GuestID
                                                        and CategoryID = @CategoryID;", sp);
            foreach (DataRow row in dataTable.Rows)
            {
                listView_myFood.Items.Add(row["FoodName"].ToString().Trim());
            }
        }

        private string GetCategoryName()
        {
            SqlParameter[] sp = { new SqlParameter("@CategoryID", categoryID) };
            DataTable dataTable = dbContext.MakeQueryDT("select CategoryName from Categories where CategoryID = @CategoryID ;", sp);
            return dataTable.Rows[0]["CategoryName"].ToString().Trim();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            Navigator.MoveToPrevCategoryForm(guestID, index);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Navigator.MoveToNextCategoryForm(guestID, index);
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
