using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatr
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnRegis_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox1.Text.Length <= 10 && textBox2.Text.Length <= 10 && textBox3.Text.Length <= 10)
                    {
                        //2
                        string userLogin = textBox1.Text.Trim();
                        string userPass = textBox2.Text.Trim();

                        SqlConnection DataStudents = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True");
                        string query = "Select * FROM Users WHERE login='" + userLogin + "'";
                        DataStudents.Open();

                        SqlCommand cmd = new SqlCommand(query, DataStudents);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже существует");
                            reader.Close();
                        }
                        else
                        {
                            //3
                            var hasNumber = new Regex(@"[0-9]+");
                            var hasUpperChar = new Regex(@"[A-Z]+");
                            var hasSymbols = new Regex(@"[!@#$%^*_+=;:.?,]");

                            if (hasNumber.IsMatch(userPass))
                            {
                                if (hasUpperChar.IsMatch(userPass))
                                {
                                    if (hasSymbols.IsMatch(userPass))
                                    {
                                        //4
                                        reader.Close();
                                        string insertquery = "INSERT INTO Users (login, password) VALUES ('" + userLogin + "','" + userPass + "')";
                                        SqlCommand cmd2 = new SqlCommand(insertquery, DataStudents);
                                        cmd2.ExecuteNonQuery();
                                        MessageBox.Show("Вы успешно зарегистрированы!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Пароль не имеет символов!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Пароль не имеет заглавную букву!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пароль не имеет цифру!");
                            }
                        }
                        DataStudents.Close();
                    }
                    else
                    {
                        MessageBox.Show("Имя пользователи или пароль должен иметь длину меньше или равно 10 символов!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void lau_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
