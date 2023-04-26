namespace Teatr
{
    partial class Vosvrat
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
            this.BtnNazad = new System.Windows.Forms.Button();
            this.BtnVosvrat = new System.Windows.Forms.Button();
            this.textBoxVos = new System.Windows.Forms.TextBox();
            this.labVos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNazad
            // 
            this.BtnNazad.Location = new System.Drawing.Point(28, 68);
            this.BtnNazad.Name = "BtnNazad";
            this.BtnNazad.Size = new System.Drawing.Size(102, 30);
            this.BtnNazad.TabIndex = 0;
            this.BtnNazad.Text = "Назад";
            this.BtnNazad.UseVisualStyleBackColor = true;
            this.BtnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // BtnVosvrat
            // 
            this.BtnVosvrat.Location = new System.Drawing.Point(297, 68);
            this.BtnVosvrat.Name = "BtnVosvrat";
            this.BtnVosvrat.Size = new System.Drawing.Size(102, 30);
            this.BtnVosvrat.TabIndex = 1;
            this.BtnVosvrat.Text = "Возврат";
            this.BtnVosvrat.UseVisualStyleBackColor = true;
            this.BtnVosvrat.Click += new System.EventHandler(this.BtnVosvrat_Click);
            // 
            // textBoxVos
            // 
            this.textBoxVos.Location = new System.Drawing.Point(28, 40);
            this.textBoxVos.Multiline = true;
            this.textBoxVos.Name = "textBoxVos";
            this.textBoxVos.Size = new System.Drawing.Size(371, 22);
            this.textBoxVos.TabIndex = 2;
            // 
            // labVos
            // 
            this.labVos.AutoSize = true;
            this.labVos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labVos.Location = new System.Drawing.Point(13, 19);
            this.labVos.Name = "labVos";
            this.labVos.Size = new System.Drawing.Size(407, 18);
            this.labVos.TabIndex = 3;
            this.labVos.Text = "Введите ID билета, которую вы хотите возвратить";
            // 
            // Vosvrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 126);
            this.Controls.Add(this.labVos);
            this.Controls.Add(this.textBoxVos);
            this.Controls.Add(this.BtnVosvrat);
            this.Controls.Add(this.BtnNazad);
            this.Name = "Vosvrat";
            this.Text = "Vosvrat";
            this.Load += new System.EventHandler(this.Vosvrat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnNazad;
        public System.Windows.Forms.Button BtnVosvrat;
        public System.Windows.Forms.TextBox textBoxVos;
        public System.Windows.Forms.Label labVos;
    }
}