namespace Teatr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRegis = new System.Windows.Forms.Button();
            this.tlog = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lazag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegis
            // 
            this.BtnRegis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegis.Location = new System.Drawing.Point(197, 241);
            this.BtnRegis.Name = "BtnRegis";
            this.BtnRegis.Size = new System.Drawing.Size(294, 47);
            this.BtnRegis.TabIndex = 0;
            this.BtnRegis.Text = "Войти";
            this.BtnRegis.UseVisualStyleBackColor = false;
            
            // 
            // tlog
            // 
            this.tlog.Location = new System.Drawing.Point(214, 148);
            this.tlog.Multiline = true;
            this.tlog.Name = "tlog";
            this.tlog.Size = new System.Drawing.Size(264, 35);
            this.tlog.TabIndex = 2;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(214, 189);
            this.tpass.Multiline = true;
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(264, 35);
            this.tpass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(125, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(116, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(241, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // lazag
            // 
            this.lazag.AutoSize = true;
            this.lazag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lazag.Location = new System.Drawing.Point(278, 9);
            this.lazag.Name = "lazag";
            this.lazag.Size = new System.Drawing.Size(363, 18);
            this.lazag.TabIndex = 7;
            this.lazag.Text = "Еще не регистрированы? Зарегистрируйтесь!";
            this.lazag.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.lazag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tlog);
            this.Controls.Add(this.BtnRegis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegis;
        private System.Windows.Forms.TextBox tlog;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lazag;
    }
}

