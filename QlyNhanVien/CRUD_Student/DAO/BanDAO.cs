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
    public class BanDAO
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
        public static List<BanDTO> LayDSBan()
        {
            List<BanDTO> _ds = new List<BanDTO>();
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
                        MySqlCommand cmd = new MySqlCommand("select * from BanAn;", cnn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                        cnn.Close();
                    }

                    client.Disconnect();
                }

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanDTO b = new BanDTO();
                b.MaBan = int.Parse(dt.Rows[i][0].ToString());
                b.SoGhe = int.Parse(dt.Rows[i][1].ToString());
                _ds.Add(b);
            }
            return _ds;
        }
    }
}
