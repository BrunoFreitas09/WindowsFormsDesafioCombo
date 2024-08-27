namespace WindowsFormsDesafioCombo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQtdEstados = new System.Windows.Forms.Label();
            this.lblQtdNorte = new System.Windows.Forms.Label();
            this.lblQtdNordeste = new System.Windows.Forms.Label();
            this.lblQtdCentro = new System.Windows.Forms.Label();
            this.lblQtdSudeste = new System.Windows.Forms.Label();
            this.lblQtdSul = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboCentro = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentroOeste = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro-Oeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul";
            // 
            // lblQtdEstados
            // 
            this.lblQtdEstados.AutoSize = true;
            this.lblQtdEstados.Location = new System.Drawing.Point(495, 50);
            this.lblQtdEstados.Name = "lblQtdEstados";
            this.lblQtdEstados.Size = new System.Drawing.Size(13, 13);
            this.lblQtdEstados.TabIndex = 6;
            this.lblQtdEstados.Text = "0";
            // 
            // lblQtdNorte
            // 
            this.lblQtdNorte.AutoSize = true;
            this.lblQtdNorte.Location = new System.Drawing.Point(483, 19);
            this.lblQtdNorte.Name = "lblQtdNorte";
            this.lblQtdNorte.Size = new System.Drawing.Size(13, 13);
            this.lblQtdNorte.TabIndex = 7;
            this.lblQtdNorte.Text = "0";
            // 
            // lblQtdNordeste
            // 
            this.lblQtdNordeste.AutoSize = true;
            this.lblQtdNordeste.Location = new System.Drawing.Point(483, 72);
            this.lblQtdNordeste.Name = "lblQtdNordeste";
            this.lblQtdNordeste.Size = new System.Drawing.Size(13, 13);
            this.lblQtdNordeste.TabIndex = 8;
            this.lblQtdNordeste.Text = "0";
            // 
            // lblQtdCentro
            // 
            this.lblQtdCentro.AutoSize = true;
            this.lblQtdCentro.Location = new System.Drawing.Point(483, 128);
            this.lblQtdCentro.Name = "lblQtdCentro";
            this.lblQtdCentro.Size = new System.Drawing.Size(13, 13);
            this.lblQtdCentro.TabIndex = 9;
            this.lblQtdCentro.Text = "0";
            // 
            // lblQtdSudeste
            // 
            this.lblQtdSudeste.AutoSize = true;
            this.lblQtdSudeste.Location = new System.Drawing.Point(483, 184);
            this.lblQtdSudeste.Name = "lblQtdSudeste";
            this.lblQtdSudeste.Size = new System.Drawing.Size(13, 13);
            this.lblQtdSudeste.TabIndex = 10;
            this.lblQtdSudeste.Text = "0";
            // 
            // lblQtdSul
            // 
            this.lblQtdSul.AutoSize = true;
            this.lblQtdSul.Location = new System.Drawing.Point(483, 240);
            this.lblQtdSul.Name = "lblQtdSul";
            this.lblQtdSul.Size = new System.Drawing.Size(13, 13);
            this.lblQtdSul.TabIndex = 11;
            this.lblQtdSul.Text = "0";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstados.Location = new System.Drawing.Point(130, 47);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(250, 21);
            this.cboEstados.TabIndex = 12;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(118, 19);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(250, 21);
            this.cboNorte.TabIndex = 13;
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(118, 72);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(250, 21);
            this.cboNordeste.TabIndex = 14;
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.Location = new System.Drawing.Point(118, 120);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(250, 21);
            this.cboCentro.TabIndex = 15;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(118, 184);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(250, 21);
            this.cboSudeste.TabIndex = 16;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(118, 237);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(250, 21);
            this.cboSul.TabIndex = 17;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(425, 44);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 25);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "-";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(413, 13);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(53, 25);
            this.btnNorte.TabIndex = 19;
            this.btnNorte.Text = "-";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // btnNordeste
            // 
            this.btnNordeste.Location = new System.Drawing.Point(413, 66);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(53, 25);
            this.btnNordeste.TabIndex = 20;
            this.btnNordeste.Text = "-";
            this.btnNordeste.UseVisualStyleBackColor = true;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // btnCentroOeste
            // 
            this.btnCentroOeste.Location = new System.Drawing.Point(413, 120);
            this.btnCentroOeste.Name = "btnCentroOeste";
            this.btnCentroOeste.Size = new System.Drawing.Size(53, 25);
            this.btnCentroOeste.TabIndex = 21;
            this.btnCentroOeste.Text = "-";
            this.btnCentroOeste.UseVisualStyleBackColor = true;
            this.btnCentroOeste.Click += new System.EventHandler(this.btnCentroOeste_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.Location = new System.Drawing.Point(413, 178);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(53, 25);
            this.btnSudeste.TabIndex = 22;
            this.btnSudeste.Text = "-";
            this.btnSudeste.UseVisualStyleBackColor = true;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(413, 237);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(53, 25);
            this.btnSul.TabIndex = 23;
            this.btnSul.Text = "-";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSul);
            this.groupBox1.Controls.Add(this.btnSudeste);
            this.groupBox1.Controls.Add(this.btnCentroOeste);
            this.groupBox1.Controls.Add(this.btnNordeste);
            this.groupBox1.Controls.Add(this.btnNorte);
            this.groupBox1.Controls.Add(this.cboSul);
            this.groupBox1.Controls.Add(this.cboSudeste);
            this.groupBox1.Controls.Add(this.cboCentro);
            this.groupBox1.Controls.Add(this.cboNordeste);
            this.groupBox1.Controls.Add(this.cboNorte);
            this.groupBox1.Controls.Add(this.lblQtdSul);
            this.groupBox1.Controls.Add(this.lblQtdSudeste);
            this.groupBox1.Controls.Add(this.lblQtdCentro);
            this.groupBox1.Controls.Add(this.lblQtdNordeste);
            this.groupBox1.Controls.Add(this.lblQtdNorte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 295);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regiões";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.lblQtdEstados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQtdEstados;
        private System.Windows.Forms.Label lblQtdNorte;
        private System.Windows.Forms.Label lblQtdNordeste;
        private System.Windows.Forms.Label lblQtdCentro;
        private System.Windows.Forms.Label lblQtdSudeste;
        private System.Windows.Forms.Label lblQtdSul;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboCentro;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.Button btnCentroOeste;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

