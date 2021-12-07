using CRUD_Student.DTO;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student.DAO
{
    public class PhanCongDAO
    {
        public static string SshHostName = DBConnection.SshHostName;
        public static string SshUserName = DBConnection.SshUserName;
        public static string SshKeyFile = DBConnection.SshKeyFile;
        public static string Server = DBConnection.Server;
        public static uint Port = DBConnection.Port;
        public static string UserID = DBConnection.UserID;
        public static string Password = DBConnection.Password;
        public static string DataBase = DBConnection.DataBase;

        public static ConnectionInfo conInFo()
        {

            ConnectionInfo cnnInfo;
            using (var stream = new FileStream(SshKeyFile, FileMode.Open, FileAccess.Read))
            {
                var file = new PrivateKeyFile(stream);
                var authMethod = new PrivateKeyAuthenticationMethod(SshUserName, file);
                cnnInfo = new ConnectionInfo(SshHostName, 22, SshUserName, authMethod);
            }
            return cnnInfo;
        }
        public static DataTable LayDSPhanCong()
        {
            /*string sql = "select Ca as 'Ca', HoTen as 'Tên Nhân Viên', MaSoBan as 'Mã Số Bàn' from QLYQUANNHAU.[dbo].[PhanCong], QLYQUANNHAU.[dbo].[NhanVien] where QLYQUANNHAU.[dbo].[PhanCong].MaNV = QLYQUANNHAU.[dbo].[NhanVien].MaNV";
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt;*/
            DataTable dt = new DataTable();
            using (var client = new SshClient(conInFo()))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                    client.AddForwardedPort(forwardedPort);
                    forwardedPort.Start();
                    string connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password};";
                    using (MySqlConnection cnn = new MySqlConnection(connStr))
                    {
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand("select Ca as 'Ca', HoTen as 'Ten Nhan Vien', MaSoBan as 'Ma So Ban' from PhanCong, NhanVien where PhanCong.MaNV = NhanVien.MaNV;", cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }

                    client.Disconnect();
                }

            }
            return dt;
        }

        public static bool ThemPhanCong(PhanCongDTO pc)
        {
            
            

            bool kq = false;

            DataTable dt = new DataTable();
            using (var client = new SshClient(conInFo()))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                    client.AddForwardedPort(forwardedPort);
                    forwardedPort.Start();
                    string connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password};";
                    using (MySqlConnection cnn = new MySqlConnection(connStr))
                    {
                        cnn.Open();
                        string sql = string.Format("insert into ResManager.[dbo].[PhanCong] values({0}, {1}, {2});", pc.Ca, pc.MsNV, pc.MsBan);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            kq = true;
                        }
                        else
                        {
                            kq = false;
                        }
                        cnn.Close();
                    }
                    client.Disconnect();
                }
            }

            return kq;
        }

        public static bool XoaPhanCong(PhanCongDTO pc)
        {
            
            
            bool kq = false;

            DataTable dt = new DataTable();
            using (var client = new SshClient(conInFo()))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                    client.AddForwardedPort(forwardedPort);
                    forwardedPort.Start();
                    string connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password};";
                    using (MySqlConnection cnn = new MySqlConnection(connStr))
                    {
                        cnn.Open();
                        string sql = string.Format("delete PhanCong where Ca = {0} and MaNV = {1} and MaSoBan = {2};", pc.Ca, pc.MsNV, pc.MsBan);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            kq = true;
                        }
                        else
                        {
                            kq = false;
                        }
                        cnn.Close();
                    }
                    client.Disconnect();
                }
            }

            return kq;
        }

        public static int LayMaNVTheoMaBanVaCa(int maBan, int ca)
        {
            
            DataTable dt = new DataTable();
            using (var client = new SshClient(conInFo()))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                    client.AddForwardedPort(forwardedPort);
                    forwardedPort.Start();
                    string connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password};";
                    using (MySqlConnection cnn = new MySqlConnection(connStr))
                    {
                        cnn.Open();
                        string sql = string.Format("select MaNV from PhanCong where MaSoBan = {0} and Ca = {1};", maBan, ca);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }

                    client.Disconnect();
                }

            }
            int maNV = int.Parse(dt.Rows[0]["MaNV"].ToString());
            return maNV;
        }
        public static int LayCaTheoGio(int gio)
        {
            int ca;
            if (gio >= 7 && gio < 11)
                ca = 1;
            else
            {
                if (gio >= 11 && gio < 18)
                    ca = 2;
                else
                    ca = 3;
            }
            return ca;
        }
    }
}
