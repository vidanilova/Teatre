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
    public partial class Addingticket : Form
    {
        SqlConnection globalconnect = new SqlConnection(@"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True");
        public Addingticket()
        {
            InitializeComponent();
        }

        private void Addingticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teatrDanilovaVDataSet2.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.teatrDanilovaVDataSet2.Tickets);

        }

        private void ButEx_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in Tickets.SelectedRows)
            {
                rowsToDelete.Add(row);
            }

            foreach (DataGridViewRow row in rowsToDelete)
            {
                Tickets.Rows.Remove(row);
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                dataRow.Delete();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }
        private void UpdateDB()
        {
            string sql = @"Data Source=DESKTOP-S9UMIH1\VICOOPERR; 
            Initial Catalog=TeatrDanilovaV; Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter ticketsTableAdapter = new SqlDataAdapter("SELECT * FROM Tickets", con);
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(ticketsTableAdapter);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Сохраняем изменения
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tickets", globalconnect);
                Tickets.DataSource = this.ticketsBindingSource;
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                Tickets.EndEdit();
                adapter.Update(dt);
                MessageBox.Show("Изменения сохранены успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
