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

namespace GuestForShabat
{
    public partial class HostForm : Form
    {
        DBContext dbContext = new DBContext();
        //public static List<int> CategoryIDList = new List<int>();



        public HostForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void OnButtonAddCategoryClick(object sender, EventArgs e)
        {
            string newCategory = textBox_addCategory.Text.Trim();
            textBox_addCategory.Clear();
            if (string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show("נא להכניס קטגוריה");
                return;
            }
            SqlParameter[] sp = { new SqlParameter("@newCategory", newCategory) };
            DataTable dataTable = dbContext.MakeQueryDT("BEGIN TRY\r\n    BEGIN TRANSACTION;\r\n    insert into Categories(CategoryName) values (@newCategory);\r\n    select 1 as result;\r\n\tCOMMIT TRANSACTION;\r\nEND TRY\r\nBEGIN CATCH\r\n        ROLLBACK TRANSACTION;\r\n\tSELECT 0 as result;\r\nEND CATCH;", sp);
            if (dataTable.Rows[0]["result"].ToString() == "0")
                MessageBox.Show("הקטגוריה קיימת כבר");
            if (dataTable.Rows[0]["result"].ToString() == "1")
            {
                LoadCategories();
                //SetCategoryIDList(dataTable.Rows[0]["result"].ToString());
            }
               
        }

        private void LoadCategories()
        {
            
            listView_categories.Clear();
            DataTable dataTable = dbContext.MakeQueryDT("select CategoryName from Categories;");
            foreach (DataRow row in dataTable.Rows)
            {
                listView_categories.Items.Add(row["CategoryName"].ToString().Trim());
            }
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
