using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBase
{
    internal class User
    {
        //constructer
        public User(string userName,string password) {
            this.UserName = userName.Trim();
            this.Password = password.Trim();
        }
        //Tek katman olduğu için internal
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int Login()
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@UserName",SqlDbType.NVarChar),
                new SqlParameter("@Password",SqlDbType.NVarChar)
           };
            parameters[0].Value = DatabaseConnection.Change(this.UserName);
            parameters[1].Value = DatabaseConnection.Change(this.Password);
            return Convert.ToInt16(DatabaseConnection.ExecuteScalar("Select * From Users Where UserName=@UserName AND Password=@Password",
                 parameters, CommandType.Text));

        }
    }
}
