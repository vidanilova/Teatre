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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teatr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teatrDanilovaVDataSet1.Vosvrat". При необходимости она может быть перемещена или удалена.
            this.vosvratTableAdapter.Fill(this.teatrDanilovaVDataSet1.Vosvrat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teatrDanilovaVDataSet.Prodazi". При необходимости она может быть перемещена или удалена.
            this.prodaziTableAdapter.Fill(this.teatrDanilovaVDataSet.Prodazi);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addingticket at = new Addingticket();
            at.Show();
            at.BtnSave.Visible = false;
            at.BtnDelete.Visible = false;
            at.BtnRefresh.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in Tabl1.SelectedRows)
            {
                Tabl1.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in rowsToDelete)
            {
                Tabl1.Rows.Remove(row);
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                dataRow.Delete();
            }

        }
        private void UpdateDB()
        {
            string sql = @"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter prodaziTableAdapter = new SqlDataAdapter("SELECT * FROM Prodazi", con);
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(prodaziTableAdapter);

            SqlDataAdapter vosvratTableAdapter = new SqlDataAdapter("SELECT * FROM Vosvrat", con);
            SqlCommandBuilder Conbuilding = new SqlCommandBuilder(vosvratTableAdapter);
        }

        private void BtnVosvrat_Click(object sender, EventArgs e)
        {
            Vosvrat at = new Vosvrat();
            at.Show();
            at.BtnNazad.Visible = false;
            at.BtnVosvrat.Visible = false;
        }

        private void BtnProd_Click(object sender, EventArgs e)
        {
            Prodaza at = new Prodaza();
            at.Show();
            at.BtnNazad.Visible = false;
            at.BtnProd.Visible = false;
        }

        private void BtnPoisk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabl1.Rows.Count; i++)
            {
                Tabl1.Rows[i].Selected = false;
                for (int j = 0; j < Tabl1.Rows.Count; j++)
                    if (Tabl1.Rows[i].Cells[j].Value != null)
                        if (Tabl1.Rows[i].Cells[j].Value.ToString().Contains(Poisk.Text))
                        {
                            Tabl1.Rows[i].Selected = true;
                            break;
                        }
            }
            for (int i = 0; i < Tabl2.Rows.Count; i++)
            {
                Tabl2.Rows[i].Selected = false;
                for (int j = 0; j < Tabl2.Rows.Count; j++)
                    if (Tabl2.Rows[i].Cells[j].Value != null)
                        if (Tabl1.Rows[i].Cells[j].Value.ToString().Contains(Poisk.Text))
                        {
                            Tabl2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            Reg mf = new Reg();
            mf.Show();
            this.Hide();
        }
    }
}
