namespace BodeOfWars
{
    partial class frmEntrarPartida
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
            this.lstListarPartidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtListarJogadores = new System.Windows.Forms.TextBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnEstrategia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstListarPartidas.FormattingEnabled = true;
            this.lstListarPartidas.ItemHeight = 20;
            this.lstListarPartidas.Location = new System.Drawing.Point(343, 75);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(509, 384);
            this.lstListarPartidas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(521, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criar um partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(866, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Entrar em uma partida";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartida.Location = new System.Drawing.Point(24, 238);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(291, 35);
            this.txtNomePartida.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome da partida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(28, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaPartida.Location = new System.Drawing.Point(24, 350);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(291, 35);
            this.txtSenhaPartida.TabIndex = 7;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(49, 406);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(201, 74);
            this.btnCriarPartida.TabIndex = 8;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(871, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(869, 227);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(291, 35);
            this.txtNomeJogador.TabIndex = 10;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.Location = new System.Drawing.Point(935, 274);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(156, 61);
            this.btnEntrarPartida.TabIndex = 11;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(870, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jogadores";
            // 
            // txtListarJogadores
            // 
            this.txtListarJogadores.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListarJogadores.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtListarJogadores.Location = new System.Drawing.Point(869, 427);
            this.txtListarJogadores.Multiline = true;
            this.txtListarJogadores.Name = "txtListarJogadores";
            this.txtListarJogadores.Size = new System.Drawing.Size(335, 92);
            this.txtListarJogadores.TabIndex = 13;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.DarkRed;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarPartidas.Location = new System.Drawing.Point(470, 465);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(244, 61);
            this.btnListarPartidas.TabIndex = 14;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.ForestGreen;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.Location = new System.Drawing.Point(1054, 373);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(126, 43);
            this.btnListarJogadores.TabIndex = 15;
            this.btnListarJogadores.Text = "Listar";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Yellow;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(242, 541);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(201, 74);
            this.btnManual.TabIndex = 16;
            this.btnManual.Text = "Jogar manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnEstrategia
            // 
            this.btnEstrategia.BackColor = System.Drawing.Color.Yellow;
            this.btnEstrategia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstrategia.Location = new System.Drawing.Point(724, 541);
            this.btnEstrategia.Name = "btnEstrategia";
            this.btnEstrategia.Size = new System.Drawing.Size(235, 74);
            this.btnEstrategia.TabIndex = 17;
            this.btnEstrategia.Text = "Jogar autônomo";
            this.btnEstrategia.UseVisualStyleBackColor = false;
            this.btnEstrategia.Click += new System.EventHandler(this.btnEstrategia_Click);
            // 
            // frmEntrarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BodeOfWars.Properties.Resources.b55051686a3dd25530d7a8d2b17f30f8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 674);
            this.Controls.Add(this.btnEstrategia);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.txtListarJogadores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstListarPartidas);
            this.DoubleBuffered = true;
            this.Name = "frmEntrarPartida";
            this.Text = "frmEntrarPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtListarJogadores;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnEstrategia;
    }
}