//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace VendingMachineSYS
{
     public class Orders
    {


        private int orderID;
        private int orderNum;
        private int menuID;

        // no argument constructer
        public Orders()
        {

        }
        public Orders(int orderID, int orderNum, int menuID)
        {

            setOrderNum(orderNum);
            setorderId(orderID);
            setMenuId(menuID);

        }

        public static int getOrderId()
         {
             int nextOrderId;

             String strSQL = "SELECT MAX(orderId) FROM order";

             OracleConnection conn = new OracleConnection( DBConnect.oradb);
             conn.Open();

             OracleCommand cmd = new OracleCommand(strSQL, conn);

             OracleDataReader dr = cmd.ExecuteReader();
             dr.Read();

             if (dr.IsDBNull(0))
               nextOrderId = 1;
             else
                 nextOrderId = dr.GetInt32(0) + 1;

             conn.Close();

             return nextOrderId;
         }
        



          public int getOrderNum()
          {
              int nextOrderNum;

              String strSQL = "SELECT MAX(orderNumber) FROM Orders";

              OracleConnection conn = new OracleConnection(DBConnect.oradb);
              conn.Open();

              OracleCommand cmd = new OracleCommand(strSQL, conn);

              OracleDataReader dr = cmd.ExecuteReader();
              dr.Read();

              if (dr.IsDBNull(0))
                  nextOrderNum = 0001;
              else
                  nextOrderNum = dr.GetInt32(0) + 1;

              conn.Close();

              return nextOrderNum;

          } 

        public void setOrderNum(int orderNum)
        {
            this.orderNum = orderNum;
        }

        public void setorderId(int orderID)
        {
            this.orderID = orderID;
        }

        public void SetMenuId(int menuID)
        {
            this.menuID = menuID;
        }

         public int GetMenuID()
         {

            int MenuID = 0;

             String strSQL = "SELECT * FROM MENU WHERE MenuId = " + menuID;
            OracleConnection conn = new OracleConnection( DBConnect.oradb);
             conn.Open();
             OracleCommand cmd = new OracleCommand(strSQL, conn);


             OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MenuID = dr.GetInt32(dr.GetOrdinal("menuId"));
            }
         

             return MenuID;

         }

         public void setMenuId(int menuId)
         {
             this.menuID = menuId;
         }

    }
}