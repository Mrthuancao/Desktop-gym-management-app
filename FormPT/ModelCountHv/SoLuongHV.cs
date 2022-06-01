using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnection = Gym_Management.DB.DbConnection;

namespace Gym_Management.FormPT.ModelCountHv
{
    public class SoLuongHV : DbConnection
    {   //Fields & Properties
        private string ma;
        private string ngay;
        public int NumHv { get; private set; }

        //Constructor
        public SoLuongHV()
        {

        }
        //Private methods
        private void GetNumberHv()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of new Customers
                    command.CommandText = @"SELECT COUNT(*) FROM [BUOITAP], [DANGKY] WHERE DANGKY.madk = BUOITAP.madk AND manv=@manv AND thoigian=@thoigian";
                    command.Parameters.Add("@manv", System.Data.SqlDbType.Char).Value= ma;
                    command.Parameters.Add("@thoigian", System.Data.SqlDbType.VarChar).Value = ngay;
                    NumHv = (int)command.ExecuteScalar();

                }
            }
        }

        public bool LoadDT(string ma, string ngay)
        {
            if (ma != this.ma || ngay != this.ngay)
            {
                this.ma = ma;
                this.ngay = ngay;
                GetNumberHv();
                Console.WriteLine("Refreshed data: {0} - {1}", ma.ToString(), ngay.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", ma.ToString(), ngay.ToString());
                return false;
            }
        }
        
    }
}
