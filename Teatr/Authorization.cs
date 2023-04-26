using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegis_Click(object sender, EventArgs e)
        {
            SqlConnection DataAuthorization = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True");
            string query = "Select * FROM Users WHERE login='" + tlog.Text + "' and password='" + tpass.Text + "'";
            DataAuthorization.Open();

            SqlCommand cmd = new SqlCommand(query, DataAuthorization);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object Login = reader.GetValue(0);
                    object Password = reader.GetValue(1);
                    object Roles = reader.GetValue(2);
                    string user_Login = Login.ToString();
                    string password_Login = Password.ToString();
                    string role_Login = Roles.ToString();

                     if (role_Login == "True")
                     {
                     MainForm f = new MainForm();
                       f.Tabl1.Visible = true;
                       f.Tabl2.Visible = true;
                       f.userLabel.Text = "Привет, " + user_Login;
                       this.Hide();
                       f.Show();
                    }

                     else if (role_Login == "False")
                     {
                       MainForm f = new MainForm();
                       f.userLabel.Text = "Привет, " + user_Login;
                       this.Hide();
                       f.Show();
                      }
                }
            }
            else MessageBox.Show("Неправильно ввели логин или пароль",
            "Ошибка!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }

        public void Role()
        {
            SqlConnection DataAuthorization = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
Initial Catalog=TeatrDanilovaV; Integrated Security=True");
            string query = "Select * FROM Users WHERE login='" + tlog.Text + "' and password='" + tpass.Text + "'";
            DataAuthorization.Open();

            SqlCommand cmd = new SqlCommand(query, DataAuthorization);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    object Login = reader.GetValue(0);
                    object Password = reader.GetValue(1);
                    object Roles = reader.GetValue(2);
                    string user_Login = Login.ToString();
                    string password_Login = Password.ToString();
                    string role_Login = Roles.ToString();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Reg f2 = new Reg();
            f2.Show();
            this.Close();
        }
    }
}
     
    


