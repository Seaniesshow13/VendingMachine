using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using Oracle.ManagedDataAccess.CLient;

namespace VendingMachineSYS
{
    class Categories
    {
        public int CatID;
        public String Name;
        public String Description;

        public Categories()
        {
            this.CatID = 0;
            this.Name = "";
            this.Description = "";
        }

        public Categories(int catID, string name, string description)
        {
            CatID = catID;
            Name = name;
            Description = description;
        }
        public int getCatID()
        {
            return this.CatID;
        }
        public void setCatID(int catID)
        {
            this.CatID = catID;

        }
        public String getName()
        {
            return this.Name;
        }
        public void setName(String Name)
        {
            this.Name = Name;
        }
        public String getDescription()
        {
            return this.Description;
        }

        public void setDescription(String description)
        {

            this.Description = description;
        }


        /*
        public void getCategory(int CatID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM CATEGORIES WHERE CatID =  " + CatID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setCatID();
            setName();
            setDescription()


        conn.Close();


        }
        public void SetCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO CATEGORIES (CatID, Name, Description) " +
                              "VALUES (:ticketID, :catCode, :description)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":ticketID", this.TicketID));
            cmd.Parameters.Add(new OracleParameter(":catCode", this.CatCode));
            cmd.Parameters.Add(new OracleParameter(":description", this.description));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        */
    }
}

