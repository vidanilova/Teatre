namespace Teatr
{
    partial class Addingticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tickets = new System.Windows.Forms.DataGridView();
            this.idbiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpectaclyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerryadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomermestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprodaziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teatrDanilovaVDataSet2 = new Teatr.TeatrDanilovaVDataSet2();
            this.ticketsTableAdapter = new Teatr.TeatrDanilovaVDataSet2TableAdapters.TicketsTableAdapter();
            this.ButEx = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tickets
            // 
            this.Tickets.AutoGenerateColumns = false;
            this.Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbiletDataGridViewTextBoxColumn,
            this.idSpectaclyaDataGridViewTextBoxColumn,
            this.nomerryadDataGridViewTextBoxColumn,
            this.nomermestaDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dataprodaziDataGridViewTextBoxColumn});
            this.Tickets.DataSource = this.ticketsBindingSource;
            this.Tickets.Location = new System.Drawing.Point(31, 24);
            this.Tickets.Name = "Tickets";
            this.Tickets.RowHeadersWidth = 51;
            this.Tickets.RowTemplate.Height = 24;
            this.Tickets.Size = new System.Drawing.Size(797, 312);
            this.Tickets.TabIndex = 0;
            this.Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tickets_CellContentClick);
            // 
            // idbiletDataGridViewTextBoxColumn
            // 
            this.idbiletDataGridViewTextBoxColumn.DataPropertyName = "id_bilet";
            this.idbiletDataGridViewTextBoxColumn.HeaderText = "id_bilet";
            this.idbiletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbiletDataGridViewTextBoxColumn.Name = "idbiletDataGridViewTextBoxColumn";
            this.idbiletDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSpectaclyaDataGridViewTextBoxColumn
            // 
            this.idSpectaclyaDataGridViewTextBoxColumn.DataPropertyName = "id_Spectaclya";
            this.idSpectaclyaDataGridViewTextBoxColumn.HeaderText = "id_Spectaclya";
            this.idSpectaclyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSpectaclyaDataGridViewTextBoxColumn.Name = "idSpectaclyaDataGridViewTextBoxColumn";
            this.idSpectaclyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomerryadDataGridViewTextBoxColumn
            // 
            this.nomerryadDataGridViewTextBoxColumn.DataPropertyName = "nomer_ryad";
            this.nomerryadDataGridViewTextBoxColumn.HeaderText = "nomer_ryad";
            this.nomerryadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomerryadDataGridViewTextBoxColumn.Name = "nomerryadDataGridViewTextBoxColumn";
            this.nomerryadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomermestaDataGridViewTextBoxColumn
            // 
            this.nomermestaDataGridViewTextBoxColumn.DataPropertyName = "nomer_mesta";
            this.nomermestaDataGridViewTextBoxColumn.HeaderText = "nomer_mesta";
            this.nomermestaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomermestaDataGridViewTextBoxColumn.Name = "nomermestaDataGridViewTextBoxColumn";
            this.nomermestaDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataprodaziDataGridViewTextBoxColumn
            // 
            this.dataprodaziDataGridViewTextBoxColumn.DataPropertyName = "data_prodazi";
            this.dataprodaziDataGridViewTextBoxColumn.HeaderText = "data_prodazi";
            this.dataprodaziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataprodaziDataGridViewTextBoxColumn.Name = "dataprodaziDataGridViewTextBoxColumn";
            this.dataprodaziDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.teatrDanilovaVDataSet2;
            // 
            // teatrDanilovaVDataSet2
            // 
            this.teatrDanilovaVDataSet2.DataSetName = "TeatrDanilovaVDataSet2";
            this.teatrDanilovaVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // ButEx
            // 
            this.ButEx.BackColor = System.Drawing.Color.IndianRed;
            this.ButEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButEx.Location = new System.Drawing.Point(754, 399);
            this.ButEx.Name = "ButEx";
            this.ButEx.Size = new System.Drawing.Size(85, 39);
            this.ButEx.TabIndex = 1;
            this.ButEx.Text = "Назад";
            this.ButEx.UseVisualStyleBackColor = false;
            this.ButEx.Click += new System.EventHandler(this.ButEx_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(488, 355);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 42);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(372, 355);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 42);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Удаление";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(256, 355);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(110, 42);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "Обновление";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Addingticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.ButEx);
            this.Controls.Add(this.Tickets);
            this.Name = "Addingticket";
            this.Text = "Addingticket";
            this.Load += new System.EventHandler(this.Addingticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Tickets;
        public TeatrDanilovaVDataSet2 teatrDanilovaVDataSet2;
        public System.Windows.Forms.BindingSource ticketsBindingSource;
        public TeatrDanilovaVDataSet2TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn idbiletDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn idSpectaclyaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nomerryadDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nomermestaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataprodaziDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button ButEx;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Button BtnRefresh;
    }
}