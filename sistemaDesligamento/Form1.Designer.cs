namespace sistemaDesligamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtAgendar = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMinutos = new System.Windows.Forms.TextBox();
            this.btnAgendarMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA O HORÁRIO";
            // 
            // dtAgendar
            // 
            this.dtAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAgendar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtAgendar.Location = new System.Drawing.Point(240, 28);
            this.dtAgendar.Name = "dtAgendar";
            this.dtAgendar.Size = new System.Drawing.Size(200, 22);
            this.dtAgendar.TabIndex = 1;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgendar.Location = new System.Drawing.Point(308, 56);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 30);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESLIGAR DAQUI À";
            // 
            // txbMinutos
            // 
            this.txbMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinutos.Location = new System.Drawing.Point(240, 119);
            this.txbMinutos.Name = "txbMinutos";
            this.txbMinutos.Size = new System.Drawing.Size(200, 22);
            this.txbMinutos.TabIndex = 4;
            // 
            // btnAgendarMin
            // 
            this.btnAgendarMin.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgendarMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarMin.Location = new System.Drawing.Point(308, 147);
            this.btnAgendarMin.Name = "btnAgendarMin";
            this.btnAgendarMin.Size = new System.Drawing.Size(75, 31);
            this.btnAgendarMin.TabIndex = 5;
            this.btnAgendarMin.Text = "AGENDAR";
            this.btnAgendarMin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "OUTROS";
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.Color.DarkGray;
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(240, 218);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(116, 31);
            this.btnDesligar.TabIndex = 7;
            this.btnDesligar.Text = "DESLIGAR AGORA";
            this.btnDesligar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(240, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgendarMin);
            this.Controls.Add(this.txbMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dtAgendar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtAgendar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMinutos;
        private System.Windows.Forms.Button btnAgendarMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

