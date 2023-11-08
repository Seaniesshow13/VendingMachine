using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSYS
{
    internal class Orders
    {

       
        private int orderID;
        private int orderNum;
        private int menuID;

        // no argument constructer
        public Orders() {

        } 
        public Orders(int orderID, int orderNum, int menuID) {

            setOrderNum(orderNum);
            setorderId(orderID);
            setMenuId(menuID);
            
        }

       /* public static int getOrderId()
        {
            int nextOrderId;

            String strSQL = "SELECT MAX(orderId) FROM order";

            OracleConnection conn = new OracleConnection(strSQL, DBConnect.oraDB);
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
       */
        
        

      /*  public int getOrderNum()
        {
            int nextOrderNum;

            String strSQL = "SELECT MAX(orderNumber) FROM Orders";

            OracleConnection conn = new OracleConnection(strSQL, DBConnect.oraDB);
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

        } */

        public void setOrderNum(int orderNum)
        {
            this.orderNum = orderNum;
        }

        public void setorderId(int orderID) { 
            this.orderID = orderID;
        }

        public void setMenuId(int menuID)
        {
            this.menuID = menuID;
        }

       /* public int GetMenuID()
        {
            String strSQL = "SELECT * FROM MENU WHERE MenuId = " + menuID;
           OracleConnection conn = new OracleConnection(strSQL, DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            return dr;

        }
         
        public void setMenuId(int menuId)
        {
            this.menuID = menuId;
        }

        
        */




         

    }
}
