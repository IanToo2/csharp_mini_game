using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace csharp_mini_game
{
    public partial class Login : Form
    {
        string _server = "155.230.235.248";
        int _port = 54036;
        string _database = "mydb";
        string _id = "swUser01";
        string _pw = "swdbUser01";
        string _connectionAddress = "";

        public static string logininfo = "";
        public static string loginnickname = "";
        public static int login_status = 0;
        public Login()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();


                    string loginid = textBox1.Text;
                    string loginpwd = textBox2.Text;
                    string selectQuery = "SELECT * FROM ksg WHERE name = \'" + loginid + "\' ";
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                    while (userAccount.Read())
                    {
                        if (loginid == (string)userAccount["name"] && loginpwd == (string)userAccount["pw"])
                        {
                            login_status = 1;
                            logininfo = (string)userAccount["id"].ToString();
                            loginnickname = (string)userAccount["nickname"];
                        }
                    }
                    mysql.Close();

                    if (login_status == 1)
                    {
                        MessageBox.Show("로그인 완료");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("회원 정보를 확인해 주세요.");
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Join showJoin = new Join(this);

            showJoin.ShowDialog();
        }
    }
}
