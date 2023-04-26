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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Teatr
{
    public partial class Vosvrat : Form
    {
        public Vosvrat()
        {
            InitializeComponent();
        }
        private void Vosvrat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teatrDanilovaVDataSet1.Vosvrat". При необходимости она может быть перемещена или удалена.
            //this.vosvratTableAdapter.Fill(this.teatrDanilovaVDataSet1.Vosvrat);
        }
        private void BtnNazad_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void BtnVosvrat_Click(object sender, EventArgs e)
        {
            string id_bilets = textBoxVos.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Vosvrat (id_biletsurs) VALUES (" + id_bilets + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы успешно сделали возврат билета!");
        }
    }
}
