using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    internal class Program
    {
        public static String User;
        public static String password;
        public static String selected;
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login frmr = new Login();
            //frm.Show();
            Application.Run(frmr);
        }
    }
}
