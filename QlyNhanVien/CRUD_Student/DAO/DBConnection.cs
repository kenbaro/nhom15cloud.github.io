using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student.DAO
{
    class DBConnection
    {
        public static string SshHostName = "54.173.99.110";
        public static string SshUserName = "ubuntu";
        public static string SshKeyFile = @"C:\Users\Msi Gp62m\Downloads\nhom15aurora.pem";
        public static string Server = "nhom15db-cluster.cluster-c8cslrsam1bq.us-east-1.rds.amazonaws.com";
        public static uint Port = 3306;
        public static string UserID = "admin";
        public static string Password = "12345678";
        public static string DataBase = "nhom15";

        /*       public static ConnectionInfo conInFo() {

            ConnectionInfo cnnInfo;
            using (var stream = new FileStream(SshKeyFile, FileMode.Open, FileAccess.Read))
            {
                var file = new PrivateKeyFile(stream);
                var authMethod = new PrivateKeyAuthenticationMethod(SshUserName, file);
                cnnInfo = new ConnectionInfo(SshHostName, 22, SshUserName, authMethod);
            }
            return cnnInfo;
        }*/

        /*public static String ConnectString() {
            string connStr="";
            using (var client = new SshClient(conInFo())) {
                client.Connect();
                if (client.IsConnected)
                {
                            var forwardedPort = new ForwardedPortLocal("127.0.0.1", Server, Port);
                            client.AddForwardedPort(forwardedPort);
                            forwardedPort.Start();
                            connStr = $"Server = {forwardedPort.BoundHost};Port = {forwardedPort.BoundPort};Database = {DataBase};Uid = {UserID};Pwd = {Password};";
                            
                }

            }
            return connStr;
        }
        public static DataTable Ban()
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
        }*/
    }
}
