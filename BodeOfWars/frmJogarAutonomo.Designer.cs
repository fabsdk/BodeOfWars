namespace BodeOfWars
{
    partial class frmJogarAutonomo
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
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnJogarPartida = new System.Windows.Forms.Button();
            this.pnlMao = new System.Windows.Forms.Panel();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txtVerificarVez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrJogar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Black;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciarPartida.Location = new System.Drawing.Point(1007, 14);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(252, 44);
            this.btnIniciarPartida.TabIndex = 0;
            this.btnIniciarPartida.Text = "INICIAR PARTIDA";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnJogarPartida
            // 
            this.btnJogarPartida.BackColor = System.Drawing.Color.Black;
            this.btnJogarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarPartida.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnJogarPartida.Location = new System.Drawing.Point(730, 14);
            this.btnJogarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogarPartida.Name = "btnJogarPartida";
            this.btnJogarPartida.Size = new System.Drawing.Size(252, 44);
            this.btnJogarPartida.TabIndex = 1;
            this.btnJogarPartida.Text = "JOGAR PARTIDA";
            this.btnJogarPartida.UseVisualStyleBackColor = false;
            this.btnJogarPartida.Click += new System.EventHandler(this.btnJogarPartida_Click);
            // 
            // pnlMao
            // 
            this.pnlMao.BackColor = System.Drawing.Color.Transparent;
            this.pnlMao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMao.Location = new System.Drawing.Point(317, 110);
            this.pnlMao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMao.Name = "pnlMao";
            this.pnlMao.Size = new System.Drawing.Size(1201, 194);
            this.pnlMao.TabIndex = 2;
            // 
            // pnlMesa
            // 
            this.pnlMesa.BackColor = System.Drawing.Color.Transparent;
            this.pnlMesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMesa.Location = new System.Drawing.Point(304, 428);
            this.pnlMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(1180, 194);
            this.pnlMesa.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BodeOfWars.Properties.Resources.pec;
            this.pictureBox1.Location = new System.Drawing.Point(1228, 704);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.Red;
            this.txtHistorico.Location = new System.Drawing.Point(8, 47);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(247, 367);
            this.txtHistorico.TabIndex = 5;
            // 
            // txtVerificarVez
            // 
            this.txtVerificarVez.BackColor = System.Drawing.Color.Red;
            this.txtVerificarVez.Location = new System.Drawing.Point(8, 471);
            this.txtVerificarVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVerificarVez.Multiline = true;
            this.txtVerificarVez.Name = "txtVerificarVez";
            this.txtVerificarVez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVerificarVez.Size = new System.Drawing.Size(247, 308);
            this.txtVerificarVez.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(1028, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "TAMANHO DA ILHA:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label.Location = new System.Drawing.Point(53, 428);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 24);
            this.label.TabIndex = 12;
            this.label.Text = "É A VEZ DE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(64, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "HISTÓRICO:";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTamanho.Location = new System.Drawing.Point(1205, 326);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(19, 20);
            this.lblTamanho.TabIndex = 14;
            this.lblTamanho.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(683, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "MINHA MÃO";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(599, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "MESA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(1232, 664);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pinky e Cérebro";
            // 
            // tmrJogar
            // 
            this.tmrJogar.Interval = 3000;
            this.tmrJogar.Tick += new System.EventHandler(this.tmrJogar_Tick);
            // 
            // frmJogarAutonomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BodeOfWars.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 856);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerificarVez);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.pnlMesa);
            this.Controls.Add(this.pnlMao);
            this.Controls.Add(this.btnJogarPartida);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJogarAutonomo";
            this.Text = "frmJogarAutonomo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnJogarPartida;
        private System.Windows.Forms.Panel pnlMao;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtVerificarVez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrJogar;
    }
}