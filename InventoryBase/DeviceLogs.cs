using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBase
{
    internal class DeviceLogs
    {
        public int Id { get; set; }
        public string HardWareNo { get; set; }

        public string Brand { get; set; }
        public string Model{ get; set; }
        public string SerialNumber { get; set; }
        public string FaultStatus { get; set; }

        public string Date { get; set; }

        public List<DeviceLogs> Fill()
        {
            List<DeviceLogs> userList = new List<DeviceLogs>();
            DataTable userTable = DatabaseConnection.ExecuteDataTable("select * from DeviceLogs");
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                DeviceLogs item = new DeviceLogs()
                {
                    Id = Convert.ToInt32(userTable.Rows[i][0]),
                    HardWareNo = userTable.Rows[i][1].ToString(),
                    Brand = userTable.Rows[i][2].ToString(),
                    Model = userTable.Rows[i][3].ToString(),
                    SerialNumber = userTable.Rows[i][4].ToString(),
                    FaultStatus = userTable.Rows[i][5].ToString(),
                    Date = userTable.Rows[i][6].ToString()
                };
                userList.Add(item);
            }
            return userList;
        }
        public string Add(string HardWareNo, string Brand, string Model, string SerialNumber, string FaultStatus,string Date)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HardWareNo",SqlDbType.NVarChar),
                new SqlParameter("@Brand",SqlDbType.NVarChar),
                new SqlParameter("@Model", SqlDbType.NVarChar),
                new SqlParameter("@SerialNumber",SqlDbType.NVarChar),
                new SqlParameter("@FaultStatus",SqlDbType.NVarChar),
                new SqlParameter("@Date",SqlDbType.NVarChar)
            };
            parameters[0].Value = HardWareNo;
            parameters[1].Value = Brand;
            parameters[2].Value = Model;
            parameters[3].Value = SerialNumber;
            parameters[4].Value = FaultStatus;
            parameters[5].Value = Date;
            MessageBox.Show("Test"+parameters.ToString());
            return Convert.ToString(DatabaseConnection.ExecuteNonQuery(
                "insert into DeviceLogs(HardWareNo,Brand,Model,SerialNumber,FaultStatus,Date) values(@HardWareNo,@Brand,@Model,@SerialNumber,@FaultStatus,@Date)", parameters));
        }
        private void ExecuteState(int execute)
        {
            if (execute != -1)
                MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                MessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Delete(int Id)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int)
            };
            parameters[0].Value = Id;
            int execute = DatabaseConnection.ExecuteNonQuery("Delete From DeviceLogs Where Id=@Id", parameters);
            ExecuteState(execute);
        }
        public string Update(int Id, string HardWareNo, string Brand, string Model, string SerialNumber,string FaultStatus,string Date)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id",SqlDbType.Int),
                new SqlParameter("@HardWareNo",SqlDbType.NVarChar),
                new SqlParameter("@Brand",SqlDbType.NVarChar),
                new SqlParameter("@Model", SqlDbType.NVarChar),
                new SqlParameter("@SerialNumber",SqlDbType.NVarChar),
                new SqlParameter("@FaultStatus",SqlDbType.NVarChar),
                new SqlParameter("@Date",SqlDbType.NVarChar)
            };
            parameters[0].Value = Id;
            parameters[1].Value = HardWareNo;
            parameters[2].Value = Brand;
            parameters[3].Value = Model;
            parameters[4].Value = SerialNumber;
            parameters[5].Value = FaultStatus;
            parameters[6].Value = Date;

            return Convert.ToString(DatabaseConnection.ExecuteNonQuery(
                "Update DeviceLogs set HardWareNo=@HardWareNo,Brand=@Brand,Model=@Model,SerialNumber=@SerialNumber,FaultStatus=@FaultStatus,Date=@Date where Id=@Id", parameters));
        }
    }
}
