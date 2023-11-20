using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSYS
{
    static class Program
    {
        internal static string connectionStr;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Categories category = new Categories();
            category.SetCategory(1, "Burgers", "Beef and Chicken Burgers");

            Categories category2 = new Categories();
            category2.SetCategory(2, "Desserts", "Ice cream, Apple Pie and Donuts");

            Categories category3 = new Categories();
            category3.SetCategory(3, "Sides", "Fries and Nuggets");

            Categories category4 = new Categories();
            category4.SetCategory(4, "Drinks", "Coco Cola,Fanta,7Up");

            Categories category5 = new Categories();
            category5.SetCategory(5, "Wraps", "Grilled,Crispy,Salad Chicken Wrap");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmOrderScreen());
        }
    }
}
