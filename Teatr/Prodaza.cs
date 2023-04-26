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
    public partial class Prodaza : Form
    {
        public Prodaza()
        {
            InitializeComponent();
        }

        private void BtnProd_Click(object sender, EventArgs e)
        {
            string id_bilets=textBoxPro.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Vosvrat (id_biletsurs) VALUES (" + id_bilets + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы успешно сделали возврат билета!");
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
