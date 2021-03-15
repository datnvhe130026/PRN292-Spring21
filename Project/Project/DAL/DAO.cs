using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Project.DAL
{
    class DAO
    {
        //function to connect DB using appConfig
        public static SqlConnection GetConnection()
        {
            string ConString = ConfigurationManager.ConnectionStrings["MyConnectionStr"].ToString();
            return new SqlConnection(ConString);
        }

        //function to execute sql with parameter
        public static int ExecuteSqlWithParameter(string sql, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
        
        //function to get data from DB 
        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //function to load all food from DB 
        public static DataTable GetAllFood()
        {
            string sql = @"SELECT Food.id, Food.name, FoodCategory.name AS categoryName, Food.status, Food.Price
                        FROM Food INNER JOIN FoodCategory ON Food.CatID = FoodCategory.id";
            return GetDataBySql(sql, null);
        }

        //function to search food by foodName
        public static DataTable GetFoodByName(string name)
        {
            string sql = @"SELECT Food.id, Food.name, FoodCategory.name AS categoryName, Food.status, Food.Price
                        FROM Food INNER JOIN FoodCategory ON Food.CatID = FoodCategory.id WHERE Food.name LIKE '%@foodName%'";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@foodName", SqlDbType.VarChar);
            pars[0].Value = name;
            return GetDataBySql(sql, pars);

        }
        //function to load all FoodCategory from DB
        public static DataTable GetAllFoodCategoryTable()
        {
            string sql = @"SELECT * FROM FoodCategory";
            return GetDataBySql(sql, null);
        }

        //function to search food by foodCategoryID
        public static DataTable GetAllFoodByFoodCateID(int foodCateID)
        {
            string sql = @"SELECT Food.id, Food.name, FoodCategory.name AS categoryName, Food.status, Food.Price
                        FROM Food INNER JOIN FoodCategory ON Food.CatID = FoodCategory.id
                        WHERE FoodCategory.id = @foodCateID";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@foodCateID", SqlDbType.Int);
            pars[0].Value = foodCateID;
            return GetDataBySql(sql, pars);
        }

        //function to add new food into DB
        public static bool addNewFood(string name, int cateID, string status, double price)
        {
            string sql = @"INSERT INTO Food (name, CatID, status, Price)
                        VALUES (@name,@cateID,@status,@price)";
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@name", SqlDbType.VarChar);
            pars[0].Value = name;
            pars[1] = new SqlParameter("@cateID", SqlDbType.Int);
            pars[1].Value = cateID;
            pars[2] = new SqlParameter("@status", SqlDbType.VarChar);
            pars[2].Value = status;
            pars[3] = new SqlParameter("@price", SqlDbType.Decimal);
            pars[3].Value = price;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }

        //function to delete food by ID
        public static bool deleteFoodByID(int Id)
        {
            string sql = @"DELETE FROM Food WHERE id = @ID";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@ID", SqlDbType.Int);
            pars[0].Value = Id;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }

        //function to update food
        public static bool updateFood(int id, string foodName, int foodCate, double price, string status)
        {
            string sql = @"UPDATE Food SET name = @foodName, CatID = @foodCate, status = @status, Price = @price WHERE id = @id";
            SqlParameter[] pars = new SqlParameter[5];
            pars[0] = new SqlParameter("@foodName", SqlDbType.VarChar);
            pars[0].Value = foodName;
            pars[1] = new SqlParameter("@foodCate", SqlDbType.Int );
            pars[1].Value = foodCate;
            pars[2] = new SqlParameter("@status", SqlDbType.VarChar);
            pars[2].Value = status;
            pars[3] = new SqlParameter("@price", SqlDbType.Int);
            pars[3].Value = price;
            pars[4] = new SqlParameter("@id", SqlDbType.Int);
            pars[4].Value = id;

            return ExecuteSqlWithParameter(sql, pars) == 1;
        }


        //function to load table foood from DB
        public static DataTable GetAllTableFood()
        {
            string sql = "SELECT * FROM TableFood";
            return GetDataBySql(sql, null);
        }

        //function to search FoodTable by Id
        public static DataTable GetAllTableByID(int Id)
        {
            string sql = @"SELECT * FROM TableFood WHERE id = @Id";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@Id", SqlDbType.Int);
            pars[0].Value = Id;
            return GetDataBySql(sql, pars);
        }

        //function to add new foodTable 

        public static bool AddNewFoodTable(string name, string status)
        {
            string sql = @"INSERT INTO TableFood(name, status) VALUES(@tableName,@status)";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@tableName", SqlDbType.VarChar);
            pars[0].Value = name;
            pars[1] = new SqlParameter("@status", SqlDbType.VarChar);
            pars[1].Value = status;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }

        //function to delete table food by Id
        public static bool deleteTableFoodByID(int ID)
        {
            string sql = "DELETE FROM TableFood WHERE id = @tableID";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@tableID", SqlDbType.Int);
            pars[0].Value = ID;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }

        //function to update food
        public static bool updateTableFood(int id, string name, string status)
        {
            string sql = @"UPDATE TableFood SET name = @name , status = @status WHERE id = @id";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@name", SqlDbType.VarChar);
            pars[0].Value = name;
            pars[1] = new SqlParameter("@status", SqlDbType.VarChar);
            pars[1].Value = status;
            pars[2] = new SqlParameter("@id", SqlDbType.Int);
            pars[2].Value = id;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }

        //function to load all foodCategory from DB
        public static DataTable GetAllFoodCategory()
        {
            string sql = "SELECT * FROM FoodCategory";
            return GetDataBySql(sql, null);
        }

        //function to search foodCategory by Id
        public static DataTable GetFoodCategoryById(int id)
        {
            string sql = "SELECT * FROM FoodCategory WHERE id = @id";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@id", SqlDbType.Int);
            pars[0].Value = id;
            return GetDataBySql(sql,pars);
        }

        //function to add new foodCategory
        public static bool addNewFoodCategory(string name)
        {
            string sql = @"INSERT INTO FoodCategory(name) VALUES (@name)";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@name", SqlDbType.VarChar);
            pars[0].Value = name;
            return ExecuteSqlWithParameter(sql, pars) == 1;
        }
        //function to delete foodCategory 
        public static bool deleteFoodCategory(int id)
        {
            string sql = @"DELETE FROM FoodCategory WHERE id = @id";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@id", SqlDbType.Int);
            pars[0].Value = id;
            return ExecuteSqlWithParameter(sql, pars)==1;
        }

        //function to update foodCategory
        public static bool updateFoodCategory(int id, string name)
        {
            string sql = @"UPDATE FoodCategory SET name = @name WHERE id = @id";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@name", SqlDbType.VarChar);
            pars[0].Value = name;
            pars[1] = new SqlParameter("@id", SqlDbType.Int);
            pars[1].Value = id;
            return ExecuteSqlWithParameter(sql, pars) == 1;

        }















    }
}
