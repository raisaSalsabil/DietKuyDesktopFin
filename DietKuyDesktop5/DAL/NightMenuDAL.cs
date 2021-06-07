using DietKuyDesktop5.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietKuyDesktop5.DAL
{
    public sealed class NightMenuDAL
    {
        //SINGLETON REFACTORING
        private static NightMenuDAL instance = null;
        public static NightMenuDAL GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new NightMenuDAL();
                return instance;
            }
        }
        private NightMenuDAL() { }
        //SINGLETON REFACTORING



        //Create a Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["DietKuyDesktop5.Properties.Settings.connstrng"].ConnectionString;


        #region SELECT data from database
        public DataTable Select()
        {
            //Create an Object to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a DataTable to Hold the Data from Database
            DataTable dt = new DataTable();

            try
            {
                // WRite SQL Qery to Get Data from Database
                String sql = "SELECT * FROM NightMenuTbl";

                //Create SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Sql Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                //Transfer Data from SqlData Adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Insert Data into Database for Night Menu Module
        public bool Insert(NightMenuBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an Object of SqlConnection to connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a String Variable to Store the INSERT Query
                String sql = "INSERT INTO NightMenuTbl(ProdId, ProdName, ProdQty, ProdPrice, ProdCat, ProdSize, ProdExtra) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdCat, @ProdSize, @ProdExtra)";

                //Create a SQL Command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the Parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@ProdId", u.ProdId);
                cmd.Parameters.AddWithValue("@ProdName", u.ProdName);
                cmd.Parameters.AddWithValue("@ProdQty", u.ProdQty);
                cmd.Parameters.AddWithValue("@ProdPrice", u.ProdPrice);
                cmd.Parameters.AddWithValue("@ProdCat", u.ProdCat);
                cmd.Parameters.AddWithValue("@ProdSize", u.ProdSize);
                cmd.Parameters.AddWithValue("@ProdExtra", u.ProdExtra);

                //Open Database Connection
                conn.Open();

                //Create an Integer VAriable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //The value of rows will be greater than 0 if the query is executed successfully
                //Else it'll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //DIsplay Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region UPDATE data in database (User Module)
        public bool Update(NightMenuBLL u)
        {
            //Create a Boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an Object for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to hold the sql query
                string sql = "UPDATE NightMenuTbl SET ProdId=@ProdId, ProdName=@ProdName, ProdQty=@ProdQty, ProdPrice=@ProdPrice, ProdCat=@ProdCat, ProdSize=@ProdSize, ProdExtra=@ProdExtra";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@ProdId", u.ProdId);
                cmd.Parameters.AddWithValue("@ProdName", u.ProdName);
                cmd.Parameters.AddWithValue("@ProdQty", u.ProdQty);
                cmd.Parameters.AddWithValue("@ProdPrice", u.ProdPrice);
                cmd.Parameters.AddWithValue("@ProdCat", u.ProdCat); ;
                cmd.Parameters.AddWithValue("@ProdSize", u.ProdSize);
                cmd.Parameters.AddWithValue("@ProdExtra", u.ProdExtra);

                //open Database Connection
                conn.Open();

                //Create an integer variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0
                //else it'll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;

                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display error message if there's any exceptional error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete Data from Database (User Module)
        public bool Delete(NightMenuBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an object for SqlConnection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to hold the sql query to delete data
                String sql = "DELETE FROM NightMenuTbl WHERE ProdId=@ProdId";

                //Create Sql Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value thorugh parameters
                cmd.Parameters.AddWithValue("@ProdId", u.ProdId);

                //Open the DAtabase Connection
                conn.Open();

                //Create an integer variable to hold the value after query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value of rows will be greater than zero(0)
                //Else it'll be zero(0)

                if (rows > 0)
                {
                    //Query executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Excetionl errors
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
    }
}
