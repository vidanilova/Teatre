namespace Teatr
{
    partial class Prodaza
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
            this.labVos = new System.Windows.Forms.Label();
            this.textBoxPro = new System.Windows.Forms.TextBox();
            this.BtnProd = new System.Windows.Forms.Button();
            this.BtnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labVos
            // 
            this.labVos.AutoSize = true;
            this.labVos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labVos.Location = new System.Drawing.Point(14, 19);
            this.labVos.Name = "labVos";
            this.labVos.Size = new System.Drawing.Size(382, 18);
            this.labVos.TabIndex = 7;
            this.labVos.Text = "Введите ID билета, которую вы хотите продать";
            // 
            // textBoxPro
            // 
            this.textBoxPro.Location = new System.Drawing.Point(29, 40);
            this.textBoxPro.Multiline = true;
            this.textBoxPro.Name = "textBoxPro";
            this.textBoxPro.Size = new System.Drawing.Size(371, 22);
            this.textBoxPro.TabIndex = 6;
            // 
            // BtnProd
            // 
            this.BtnProd.Location = new System.Drawing.Point(298, 68);
            this.BtnProd.Name = "BtnProd";
            this.BtnProd.Size = new System.Drawing.Size(102, 30);
            this.BtnProd.TabIndex = 5;
            this.BtnProd.Text = "Продать";
            this.BtnProd.UseVisualStyleBackColor = true;
            this.BtnProd.Click += new System.EventHandler(this.BtnProd_Click);
            // 
            // BtnNazad
            // 
            this.BtnNazad.Location = new System.Drawing.Point(29, 68);
            this.BtnNazad.Name = "BtnNazad";
            this.BtnNazad.Size = new System.Drawing.Size(102, 30);
            this.BtnNazad.TabIndex = 4;
            this.BtnNazad.Text = "Назад";
            this.BtnNazad.UseVisualStyleBackColor = true;
            this.BtnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // Prodaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 125);
            this.Controls.Add(this.labVos);
            this.Controls.Add(this.textBoxPro);
            this.Controls.Add(this.BtnProd);
            this.Controls.Add(this.BtnNazad);
            this.Name = "Prodaza";
            this.Text = "Prodaza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labVos;
        public System.Windows.Forms.TextBox textBoxPro;
        public System.Windows.Forms.Button BtnProd;
        public System.Windows.Forms.Button BtnNazad;
    }
}