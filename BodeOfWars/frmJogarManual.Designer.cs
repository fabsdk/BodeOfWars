﻿namespace BodeOfWars
{
    partial class frmJogarManual
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
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVerficarVez = new System.Windows.Forms.Button();
            this.txtVerificarVez = new System.Windows.Forms.TextBox();
            this.pnlMao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListarCartas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarCartas = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificarHistorico = new System.Windows.Forms.Button();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.btnVerificarMao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerificarMesa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBode = new System.Windows.Forms.TextBox();
            this.txtIlha = new System.Windows.Forms.TextBox();
            this.btnJogarBode = new System.Windows.Forms.Button();
            this.btnJogarIlha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.btnVerificarIlha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarPartida.Location = new System.Drawing.Point(105, -1);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(1181, 31);
            this.btnIniciarPartida.TabIndex = 2;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVerficarVez
            // 
            this.btnVerficarVez.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerficarVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerficarVez.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerficarVez.Location = new System.Drawing.Point(8, 398);
            this.btnVerficarVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerficarVez.Name = "btnVerficarVez";
            this.btnVerficarVez.Size = new System.Drawing.Size(199, 34);
            this.btnVerficarVez.TabIndex = 3;
            this.btnVerficarVez.Text = "Verificar Vez";
            this.btnVerficarVez.UseVisualStyleBackColor = false;
            this.btnVerficarVez.Click += new System.EventHandler(this.btnVerficarVez_Click);
            // 
            // txtVerificarVez
            // 
            this.txtVerificarVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificarVez.Location = new System.Drawing.Point(8, 266);
            this.txtVerificarVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVerificarVez.Multiline = true;
            this.txtVerificarVez.Name = "txtVerificarVez";
            this.txtVerificarVez.ReadOnly = true;
            this.txtVerificarVez.Size = new System.Drawing.Size(199, 129);
            this.txtVerificarVez.TabIndex = 4;
            // 
            // pnlMao
            // 
            this.pnlMao.BackColor = System.Drawing.Color.Transparent;
            this.pnlMao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMao.Location = new System.Drawing.Point(8, 29);
            this.pnlMao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMao.Name = "pnlMao";
            this.pnlMao.Size = new System.Drawing.Size(1279, 189);
            this.pnlMao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "É a vez de quem? ";
            // 
            // txtListarCartas
            // 
            this.txtListarCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListarCartas.Location = new System.Drawing.Point(8, 499);
            this.txtListarCartas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtListarCartas.Multiline = true;
            this.txtListarCartas.Name = "txtListarCartas";
            this.txtListarCartas.ReadOnly = true;
            this.txtListarCartas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListarCartas.Size = new System.Drawing.Size(199, 273);
            this.txtListarCartas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cartas";
            // 
            // btnListarCartas
            // 
            this.btnListarCartas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCartas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListarCartas.Location = new System.Drawing.Point(5, 776);
            this.btnListarCartas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarCartas.Name = "btnListarCartas";
            this.btnListarCartas.Size = new System.Drawing.Size(199, 34);
            this.btnListarCartas.TabIndex = 9;
            this.btnListarCartas.Text = "Listar Cartas";
            this.btnListarCartas.UseVisualStyleBackColor = false;
            this.btnListarCartas.Click += new System.EventHandler(this.btnListarCartas_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(230, 276);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHistorico.Size = new System.Drawing.Size(497, 458);
            this.txtHistorico.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Histórico do Jogo";
            // 
            // btnVerificarHistorico
            // 
            this.btnVerificarHistorico.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarHistorico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarHistorico.Location = new System.Drawing.Point(382, 760);
            this.btnVerificarHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificarHistorico.Name = "btnVerificarHistorico";
            this.btnVerificarHistorico.Size = new System.Drawing.Size(199, 34);
            this.btnVerificarHistorico.TabIndex = 12;
            this.btnVerificarHistorico.Text = "Verificar Histórico";
            this.btnVerificarHistorico.UseVisualStyleBackColor = false;
            this.btnVerificarHistorico.Click += new System.EventHandler(this.btnVerificarHistorico_Click);
            // 
            // pnlMesa
            // 
            this.pnlMesa.BackColor = System.Drawing.Color.Transparent;
            this.pnlMesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMesa.Location = new System.Drawing.Point(769, 307);
            this.pnlMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(707, 176);
            this.pnlMesa.TabIndex = 13;
            // 
            // btnVerificarMao
            // 
            this.btnVerificarMao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificarMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarMao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarMao.Location = new System.Drawing.Point(1075, 234);
            this.btnVerificarMao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificarMao.Name = "btnVerificarMao";
            this.btnVerificarMao.Size = new System.Drawing.Size(199, 34);
            this.btnVerificarMao.TabIndex = 14;
            this.btnVerificarMao.Text = "Verificar Mão";
            this.btnVerificarMao.UseVisualStyleBackColor = false;
            this.btnVerificarMao.Click += new System.EventHandler(this.btnVerificarMao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mesa";
            // 
            // btnVerificarMesa
            // 
            this.btnVerificarMesa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarMesa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarMesa.Location = new System.Drawing.Point(1059, 491);
            this.btnVerificarMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificarMesa.Name = "btnVerificarMesa";
            this.btnVerificarMesa.Size = new System.Drawing.Size(199, 34);
            this.btnVerificarMesa.TabIndex = 16;
            this.btnVerificarMesa.Text = "Verificar Mesa";
            this.btnVerificarMesa.UseVisualStyleBackColor = false;
            this.btnVerificarMesa.Click += new System.EventHandler(this.btnVerificarMesa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jogar Bode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1088, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Jogar Ilha";
            // 
            // txtBode
            // 
            this.txtBode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBode.Location = new System.Drawing.Point(773, 578);
            this.txtBode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBode.Name = "txtBode";
            this.txtBode.Size = new System.Drawing.Size(133, 26);
            this.txtBode.TabIndex = 19;
            // 
            // txtIlha
            // 
            this.txtIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIlha.Location = new System.Drawing.Point(1059, 579);
            this.txtIlha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIlha.Name = "txtIlha";
            this.txtIlha.Size = new System.Drawing.Size(150, 26);
            this.txtIlha.TabIndex = 20;
            // 
            // btnJogarBode
            // 
            this.btnJogarBode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnJogarBode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarBode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJogarBode.Location = new System.Drawing.Point(741, 619);
            this.btnJogarBode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogarBode.Name = "btnJogarBode";
            this.btnJogarBode.Size = new System.Drawing.Size(199, 34);
            this.btnJogarBode.TabIndex = 21;
            this.btnJogarBode.Text = "Jogar Bode";
            this.btnJogarBode.UseVisualStyleBackColor = false;
            this.btnJogarBode.Click += new System.EventHandler(this.btnJogarBode_Click);
            // 
            // btnJogarIlha
            // 
            this.btnJogarIlha.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnJogarIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarIlha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJogarIlha.Location = new System.Drawing.Point(1033, 617);
            this.btnJogarIlha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogarIlha.Name = "btnJogarIlha";
            this.btnJogarIlha.Size = new System.Drawing.Size(199, 34);
            this.btnJogarIlha.TabIndex = 22;
            this.btnJogarIlha.Text = "JogarIlha";
            this.btnJogarIlha.UseVisualStyleBackColor = false;
            this.btnJogarIlha.Click += new System.EventHandler(this.btnJogarIlha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(5, 0);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 27);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tamanho da Ilha: ";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(905, 224);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(14, 20);
            this.lblTamanho.TabIndex = 25;
            this.lblTamanho.Text = "t";
            // 
            // btnVerificarIlha
            // 
            this.btnVerificarIlha.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificarIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarIlha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarIlha.Location = new System.Drawing.Point(931, 220);
            this.btnVerificarIlha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificarIlha.Name = "btnVerificarIlha";
            this.btnVerificarIlha.Size = new System.Drawing.Size(78, 28);
            this.btnVerificarIlha.TabIndex = 26;
            this.btnVerificarIlha.Text = "Verificar";
            this.btnVerificarIlha.UseVisualStyleBackColor = false;
            this.btnVerificarIlha.Click += new System.EventHandler(this.btnVerificarIlha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BodeOfWars.Properties.Resources.pec;
            this.pictureBox1.Location = new System.Drawing.Point(1281, 669);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1315, 629);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pinky e Cérebro";
            // 
            // frmJogarManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BodeOfWars.Properties.Resources.fundonovo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 881);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerificarIlha);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnJogarIlha);
            this.Controls.Add(this.btnJogarBode);
            this.Controls.Add(this.txtIlha);
            this.Controls.Add(this.txtBode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerificarMesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerificarMao);
            this.Controls.Add(this.pnlMesa);
            this.Controls.Add(this.btnVerificarHistorico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.btnListarCartas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtListarCartas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMao);
            this.Controls.Add(this.txtVerificarVez);
            this.Controls.Add(this.btnVerficarVez);
            this.Controls.Add(this.btnIniciarPartida);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJogarManual";
            this.Text = "frmJogarManual";
            this.Load += new System.EventHandler(this.frmJogarManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnVerficarVez;
        private System.Windows.Forms.TextBox txtVerificarVez;
        private System.Windows.Forms.Panel pnlMao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListarCartas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarCartas;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificarHistorico;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.Button btnVerificarMao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerificarMesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBode;
        private System.Windows.Forms.TextBox txtIlha;
        private System.Windows.Forms.Button btnJogarBode;
        private System.Windows.Forms.Button btnJogarIlha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnVerificarIlha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}