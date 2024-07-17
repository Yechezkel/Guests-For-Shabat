using GuestForShabat.DAL;
using GuestForShabat.GuestSide;
using GuestForShabat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestForShabat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Navigator.SetCategoryIDList();
            //new HostForm().Show();
            new GuestForm().Show();
            Application.Run();

        }
    }
}
