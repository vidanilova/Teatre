namespace Teatr
{
    partial class MainForm
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
            this.teatrDanilovaVDataSet = new Teatr.TeatrDanilovaVDataSet();
            this.prodaziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaziTableAdapter = new Teatr.TeatrDanilovaVDataSetTableAdapters.ProdaziTableAdapter();
            this.teatrDanilovaVDataSet1 = new Teatr.TeatrDanilovaVDataSet1();
            this.vosvratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vosvratTableAdapter = new Teatr.TeatrDanilovaVDataSet1TableAdapters.VosvratTableAdapter();
            this.ButExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnVosvrat = new System.Windows.Forms.Button();
            this.BtnProd = new System.Windows.Forms.Button();
            this.Poisk = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.ButFoundTik = new System.Windows.Forms.Button();
            this.Tabl1 = new System.Windows.Forms.DataGridView();
            this.idvosvratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbiletsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavosvratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabl2 = new System.Windows.Forms.DataGridView();
            this.idprodazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbiletsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprodaziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPoisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vosvratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl2)).BeginInit();
            this.SuspendLayout();
            // 
            // teatrDanilovaVDataSet
            // 
            this.teatrDanilovaVDataSet.DataSetName = "TeatrDanilovaVDataSet";
            this.teatrDanilovaVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodaziBindingSource
            // 
            this.prodaziBindingSource.DataMember = "Prodazi";
            this.prodaziBindingSource.DataSource = this.teatrDanilovaVDataSet;
            // 
            // prodaziTableAdapter
            // 
            this.prodaziTableAdapter.ClearBeforeFill = true;
            // 
            // teatrDanilovaVDataSet1
            // 
            this.teatrDanilovaVDataSet1.DataSetName = "TeatrDanilovaVDataSet1";
            this.teatrDanilovaVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vosvratBindingSource
            // 
            this.vosvratBindingSource.DataMember = "Vosvrat";
            this.vosvratBindingSource.DataSource = this.teatrDanilovaVDataSet1;
            // 
            // vosvratTableAdapter
            // 
            this.vosvratTableAdapter.ClearBeforeFill = true;
            // 
            // ButExit
            // 
            this.ButExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ButExit.Location = new System.Drawing.Point(720, 12);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(75, 29);
            this.ButExit.TabIndex = 2;
            this.ButExit.Text = "Выход";
            this.ButExit.UseVisualStyleBackColor = true;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(261, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnVosvrat
            // 
            this.BtnVosvrat.Location = new System.Drawing.Point(448, 313);
            this.BtnVosvrat.Name = "BtnVosvrat";
            this.BtnVosvrat.Size = new System.Drawing.Size(90, 37);
            this.BtnVosvrat.TabIndex = 5;
            this.BtnVosvrat.Text = "Возврат";
            this.BtnVosvrat.UseVisualStyleBackColor = true;
            this.BtnVosvrat.Click += new System.EventHandler(this.BtnVosvrat_Click);
            // 
            // BtnProd
            // 
            this.BtnProd.Location = new System.Drawing.Point(539, 313);
            this.BtnProd.Name = "BtnProd";
            this.BtnProd.Size = new System.Drawing.Size(90, 37);
            this.BtnProd.TabIndex = 6;
            this.BtnProd.Text = "Продать";
            this.BtnProd.UseVisualStyleBackColor = true;
            this.BtnProd.Click += new System.EventHandler(this.BtnProd_Click);
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(59, 264);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(306, 22);
            this.Poisk.TabIndex = 8;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(12, 18);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(81, 18);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "userLabel";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // ButFoundTik
            // 
            this.ButFoundTik.Location = new System.Drawing.Point(631, 313);
            this.ButFoundTik.Name = "ButFoundTik";
            this.ButFoundTik.Size = new System.Drawing.Size(172, 37);
            this.ButFoundTik.TabIndex = 11;
            this.ButFoundTik.Text = "Просмотр билетов";
            this.ButFoundTik.UseVisualStyleBackColor = true;
            this.ButFoundTik.Click += new System.EventHandler(this.button5_Click);
            // 
            // Tabl1
            // 
            this.Tabl1.AutoGenerateColumns = false;
            this.Tabl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvosvratDataGridViewTextBoxColumn,
            this.idbiletsDataGridViewTextBoxColumn,
            this.datavosvratDataGridViewTextBoxColumn});
            this.Tabl1.DataSource = this.vosvratBindingSource;
            this.Tabl1.Location = new System.Drawing.Point(12, 67);
            this.Tabl1.Name = "Tabl1";
            this.Tabl1.RowHeadersWidth = 51;
            this.Tabl1.RowTemplate.Height = 24;
            this.Tabl1.Size = new System.Drawing.Size(386, 187);
            this.Tabl1.TabIndex = 12;
            // 
            // idvosvratDataGridViewTextBoxColumn
            // 
            this.idvosvratDataGridViewTextBoxColumn.DataPropertyName = "id_vosvrat";
            this.idvosvratDataGridViewTextBoxColumn.HeaderText = "id_vosvrat";
            this.idvosvratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvosvratDataGridViewTextBoxColumn.Name = "idvosvratDataGridViewTextBoxColumn";
            this.idvosvratDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbiletsDataGridViewTextBoxColumn
            // 
            this.idbiletsDataGridViewTextBoxColumn.DataPropertyName = "id_bilets";
            this.idbiletsDataGridViewTextBoxColumn.HeaderText = "id_bilets";
            this.idbiletsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbiletsDataGridViewTextBoxColumn.Name = "idbiletsDataGridViewTextBoxColumn";
            this.idbiletsDataGridViewTextBoxColumn.Width = 125;
            // 
            // datavosvratDataGridViewTextBoxColumn
            // 
            this.datavosvratDataGridViewTextBoxColumn.DataPropertyName = "Data_vosvrat";
            this.datavosvratDataGridViewTextBoxColumn.HeaderText = "Data_vosvrat";
            this.datavosvratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datavosvratDataGridViewTextBoxColumn.Name = "datavosvratDataGridViewTextBoxColumn";
            this.datavosvratDataGridViewTextBoxColumn.Width = 125;
            // 
            // Tabl2
            // 
            this.Tabl2.AutoGenerateColumns = false;
            this.Tabl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodazaDataGridViewTextBoxColumn,
            this.idbiletsDataGridViewTextBoxColumn1,
            this.dataprodaziDataGridViewTextBoxColumn});
            this.Tabl2.DataSource = this.prodaziBindingSource;
            this.Tabl2.Location = new System.Drawing.Point(405, 67);
            this.Tabl2.Name = "Tabl2";
            this.Tabl2.RowHeadersWidth = 51;
            this.Tabl2.RowTemplate.Height = 24;
            this.Tabl2.Size = new System.Drawing.Size(386, 187);
            this.Tabl2.TabIndex = 13;
            this.Tabl2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idprodazaDataGridViewTextBoxColumn
            // 
            this.idprodazaDataGridViewTextBoxColumn.DataPropertyName = "id_prodaza";
            this.idprodazaDataGridViewTextBoxColumn.HeaderText = "id_prodaza";
            this.idprodazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodazaDataGridViewTextBoxColumn.Name = "idprodazaDataGridViewTextBoxColumn";
            this.idprodazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbiletsDataGridViewTextBoxColumn1
            // 
            this.idbiletsDataGridViewTextBoxColumn1.DataPropertyName = "id_bilets";
            this.idbiletsDataGridViewTextBoxColumn1.HeaderText = "id_bilets";
            this.idbiletsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idbiletsDataGridViewTextBoxColumn1.Name = "idbiletsDataGridViewTextBoxColumn1";
            this.idbiletsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataprodaziDataGridViewTextBoxColumn
            // 
            this.dataprodaziDataGridViewTextBoxColumn.DataPropertyName = "Data_prodazi";
            this.dataprodaziDataGridViewTextBoxColumn.HeaderText = "Data_prodazi";
            this.dataprodaziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataprodaziDataGridViewTextBoxColumn.Name = "dataprodaziDataGridViewTextBoxColumn";
            this.dataprodaziDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поиск:";
            // 
            // BtnPoisk
            // 
            this.BtnPoisk.Location = new System.Drawing.Point(372, 262);
            this.BtnPoisk.Name = "BtnPoisk";
            this.BtnPoisk.Size = new System.Drawing.Size(75, 23);
            this.BtnPoisk.TabIndex = 15;
            this.BtnPoisk.Text = "Поиск";
            this.BtnPoisk.UseVisualStyleBackColor = true;
            this.BtnPoisk.Click += new System.EventHandler(this.BtnPoisk_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(807, 356);
            this.Controls.Add(this.BtnPoisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabl2);
            this.Controls.Add(this.Tabl1);
            this.Controls.Add(this.ButFoundTik);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.BtnProd);
            this.Controls.Add(this.BtnVosvrat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButExit);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatrDanilovaVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vosvratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TeatrDanilovaVDataSet teatrDanilovaVDataSet;
        public System.Windows.Forms.BindingSource prodaziBindingSource;
        public TeatrDanilovaVDataSetTableAdapters.ProdaziTableAdapter prodaziTableAdapter;
        public TeatrDanilovaVDataSet1 teatrDanilovaVDataSet1;
        public System.Windows.Forms.BindingSource vosvratBindingSource;
        public TeatrDanilovaVDataSet1TableAdapters.VosvratTableAdapter vosvratTableAdapter;
        public System.Windows.Forms.Button ButExit;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button BtnVosvrat;
        public System.Windows.Forms.Button BtnProd;
        public System.Windows.Forms.TextBox Poisk;
        public System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.Button ButFoundTik;
        public System.Windows.Forms.DataGridView Tabl1;
        public System.Windows.Forms.DataGridViewTextBoxColumn idvosvratDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn idbiletsDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn datavosvratDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView Tabl2;
        public System.Windows.Forms.DataGridViewTextBoxColumn idprodazaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn idbiletsDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataprodaziDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPoisk;
    }
}