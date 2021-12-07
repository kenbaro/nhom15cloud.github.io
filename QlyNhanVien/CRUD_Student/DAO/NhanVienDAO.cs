
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
    public class NhanVienDAO
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

        public static int MaTuTang()
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
                        MySqlCommand cmd = new MySqlCommand("select * from NhanVien;", cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }

                    client.Disconnect();
                }
            }
            int maTuTang = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count == maTuTang)
                    return maTuTang + 1;
                maTuTang++;
            }
            return maTuTang;
        }
        public static DataTable LayDSNhanVienCoMK()
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
                        MySqlCommand cmd = new MySqlCommand("select * from NhanVien;", cnn);
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
        public static DataTable LayDSNhanVien()
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
                        MySqlCommand cmd = new MySqlCommand("select MaNV , HoTen , TenDN , Quyen from NhanVien;", cnn);
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

        public static DataTable LayDSNhanVienTiepTan()
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
                        MySqlCommand cmd = new MySqlCommand("select MaNV, HoTen, TenDN , Quyen from NhanVien where Quyen = 'Tiep Tan';", cnn);
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
        public static string LayMatKhauTuTenDN(string TenDN)
        {
            /*string sql = "select * from QLYQUANNHAU.[dbo].[NhanVien] where TenDN = N'" + TenDN + "'";
            DataTable dt = DataProvider.ExecuteQuery(sql);*/
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
                        MySqlCommand cmd = new MySqlCommand("select * from NhanVien where TenDN = N'" + TenDN + "';", cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }

            }
            string MK = dt.Rows[0][3].ToString();
            return MK;
        }
        public static int LayMaNVTuTenNV(string tenNV)
        {
            int maNV;
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
                        string sql = string.Format("select MaNV from NhanVien where  HoTen = {0};", tenNV);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }

            }

            if (dt.Rows.Count > 0)
            {
                maNV = int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
            return maNV;
        }
        public static string LayTenNVTheoMaNV(int maNV)
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
                        string sql = string.Format("select HoTen from NhanVien where MaNV = {0};", maNV);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }

                string tenNV = dt.Rows[0]["HoTen"].ToString();
                return tenNV;
            }

        }
        public static string LayQuyenNVTheoMaNV(int maNV)
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
                        string sql = "select Quyen from NhanVien where MaNV = " + maNV+";";
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }
                string quyen = dt.Rows[0]["Quyen"].ToString();
                return quyen;
            }
        }
        public static bool KiemTraTenDNTonTai(string tenDN, int MaNV)
        {
            bool kq;
            
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
                        string sql = "select * from NhanVien where TenDN = '" + tenDN + "'" + "and TenDN <> '' and MaNV <> " + MaNV+";";
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }
            }
            if (dt.Rows.Count > 0)
                kq = true;
            else
                kq = false;
            return kq;
        }
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            nv.MaNV = MaTuTang();
            bool kq=false;
          
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
                        string sql = string.Format("insert into NhanVien values ({0}, N'{1}', N'{2}', N'{3}', N'{4}');", nv.MaNV, nv.HoTen, nv.TenDN, nv.MatKhau, nv.Quyen);
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
        public static bool CapNhatNhanVien(NhanVienDTO nv)
        {
            bool kq=false;
           
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
                        string sql = string.Format("update NhanVien set HoTen = N'{0}',  TenDN = '{1}', MatKhau = '{2}', Quyen = N'{3}' where MaNV = {4};", nv.HoTen, nv.TenDN, nv.MatKhau, nv.Quyen, nv.MaNV);
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

        public static bool XoaNhanVien(int maNV)
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
                        string sql = string.Format("delete from NhanVien where MaNV = {0};", maNV);
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

        public static DataTable TraCuuNhanVienTheoTen(string tenNV)
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
                        string sql = string.Format("select MaNV , HoTen, TenDN , Quyen from NhanVien where HoTen like N'%{0}%';", tenNV);
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }
                    client.Disconnect();
                }
                return dt;
            }
        }
    }
}
