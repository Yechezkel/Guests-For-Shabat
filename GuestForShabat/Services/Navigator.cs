using GuestForShabat.DAL;
using GuestForShabat.GuestSide;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestForShabat.Services
{
    internal static class Navigator
    {
        public static bool isNavigate = false;
        public static List<int> CategoryIDList = new List<int>();
        static DBContext dbContext = new DBContext();


        private static void CloseAllForms()
        {
            foreach (Form item in new List<Form>(Application.OpenForms.Cast<Form>()))
                item.Close();
        }

        public static void MoveToNextCategoryForm(int guestID, int SenderIndex)
        {
            int newIndex = SenderIndex + 1;
            if (newIndex == CategoryIDList.Count)
            {
                MessageBox.Show("אין יותר קטגוריות");
                return;
            }
            isNavigate = true;
            Form form = new CategoryForm(guestID, CategoryIDList[newIndex], newIndex);
            CloseAllForms();
            form.Show();
            isNavigate = false;
        }

        public static void MoveToPrevCategoryForm(int guestID, int SenderIndex)
        {
            int newIndex = SenderIndex - 1;
            Form form;
            isNavigate = true;
            if (newIndex <0)
                form = new GuestForm();
            else
                form = new CategoryForm(guestID, CategoryIDList[newIndex], newIndex);
            CloseAllForms();
            form.Show();
            isNavigate = false;


        }


        public static void SetCategoryIDList()//string strNewCategoryID)    //לעדכן את הליסט בכל פעם בו המארח מוסיף קטגוריה
        {
            int newCategoryID;
            DataTable dataTable = dbContext.MakeQueryDT("select CategoryID from Categories;");
            foreach (DataRow row in dataTable.Rows)
            {
                newCategoryID = int.Parse(row["CategoryID"].ToString().Trim());
                CategoryIDList.Add(newCategoryID);
            }
        }





    }
}
