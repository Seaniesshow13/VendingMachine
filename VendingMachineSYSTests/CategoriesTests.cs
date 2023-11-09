using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineSYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

[TestClass]
public class CategoriesTests
{
    [TestMethod]
    public void TestSetCategory()
    {
        // Arrange
        Categories category = new Categories();

        // Provide test data
        int catID = 1;
        string name = "Burgers";
        string description = "Beef and Chicken";

        category.SetCategory(catID, name, description);


        // Verify that the category has been inserted into the database
        /*
        // Create a connection to your Oracle database using the same connection string (DBConnect.oradb)
        using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
        {
            conn.Open();

            // Execute a SQL query to retrieve the category you just inserted
            string sqlQuery = "SELECT * FROM CATEGORIES WHERE CatID = :catID";
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add(new OracleParameter(":catID", catID));

                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    // Check if there is a result
                    if (dr.Read())
                    {
                        // Verify the properties of the retrieved category
                        Assert.AreEqual(catID, dr.GetInt32(dr.GetOrdinal("CatID")));
                        Assert.AreEqual(name, dr.GetString(dr.GetOrdinal("Name")));
                        Assert.AreEqual(description, dr.GetString(dr.GetOrdinal("Description")));
                    }
                    else
                    {
                        Assert.Fail("Category not found in the database.");
                    }
        */
                }
            }
       