using Npgsql;
using System;
using System.Net;
using System.Web;



namespace PostgresRequests
{

    class PgReq
    {
        public string[] tableNames = new string[6];

        public PgReq()
        {
            tableNames[0] = "Min_6";
            tableNames[1] = "Min_30";
            tableNames[2] = "Hour_3";
            tableNames[3] = "Day_1";
            tableNames[4] = "Day_7";
            tableNames[5] = "Week_4";
        }

        public bool Insert(int cont, string price, string date)
        {
            try
            {
                var cs = "Host=localhost;Username=postgres;Password=s$cret;Database=testdb";

                using var con = new NpgsqlConnection(cs);
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO " + tableNames[cont] + "(date, price) VALUES(" + date + "," + price + ")";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            
        }
    }
}