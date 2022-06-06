using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

namespace BodeOfWars
{
    public partial class frmJogarManual : Form
    {
        public int idPartida { get; set; }
        public string senhaJogador { get; set; }
        public int idJogador { get; set; }

        string iniciarPartida;

        private string[] cartasMao;

        private string[] cartasMesa;

        private string[] Ultima;

        private string verMesa;

        public frmJogarManual()
        {
            InitializeComponent();
        }

        private void frmJogarManual_Load(object sender, EventArgs e)
        {

        }


        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
           iniciarPartida = Jogo.IniciarPartida(idJogador, senhaJogador);

            if (iniciarPartida.Contains("ERRO"))
            {
                MessageBox.Show(iniciarPartida, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Partida iniciada com sucesso");
            }
        }

        private void btnVerficarVez_Click(object sender, EventArgs e)
        {
            string vez = Jogo.VerificarVez(idPartida);
            txtVerificarVez.Text = vez;
        }

        private void btnListarCartas_Click(object sender, EventArgs e)
        {
            txtListarCartas.Text = Jogo.ListarCartas();
        }

        private void btnVerificarHistorico_Click(object sender, EventArgs e)
        {
            if(iniciarPartida.Contains("ERRO: "))
            {
                MessageBox.Show(iniciarPartida, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txtHistorico.Text = Jogo.ExibirNarracao(idPartida);
        }

        private void btnVerificarMao_Click(object sender, EventArgs e)
        {
            string mao = Jogo.VerificarMao(idJogador, senhaJogador);
            mao = mao.Replace('\r', ' ');
            cartasMao = mao.Split('\n');

            this.pnlMao.Controls.Clear();

            if (cartasMao != null)
            {
                mostrarCarta(cartasMao, pnlMao);
            }
        }

        private void btnJogarBode_Click(object sender, EventArgs e)
        {
            if(txtBode.Text == "")
            {
                MessageBox.Show("Escolha uma carta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idCarta = Int32.Parse(txtBode.Text);
                Jogo.Jogar(idJogador, senhaJogador, idCarta);
            }
            txtBode.Clear();
        }

        private void btnJogarIlha_Click(object sender, EventArgs e)
        {
            if(txtIlha.Text == "")
            {
                MessageBox.Show("Escolha um tamanho de ilha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int numIlha = Int32.Parse(txtIlha.Text);
                Jogo.DefinirIlha(idJogador, senhaJogador, numIlha);
            }

            txtIlha.Clear();
        }


        private string[] EncontrarCarta(string[] cartaMao, int idChecar)
        {

            string cartas = Jogo.ListarCartas();
            cartas = cartas.Replace('\r', ' ');
            string[] cartasValores = cartas.Split('\n');

            if (cartaMao.Length <= 0 || cartaMao[0].Contains("ERRO:"))
            {
                return null;
            }
            for (int i = 0; i < cartasValores.Length - 1; i++)
            {
                string[] aux = cartasValores[i].Split(',');
                int valorCarta = Int32.Parse(aux[0]);
                int valorMao = Int32.Parse(cartaMao[idChecar]);

                if (valorCarta == valorMao)
                {
                    return aux;
                }

            }
            return null;
        }


        private void mostrarCarta(string[] cartas, Panel panel)
        {
            int x = 20;
            int y = 8;
            int alturaMax = -1;

            string nomeFont = "Microsoft Sans Serif";
            int tamanhoFont = 10;

            panel.Controls.Clear();

            foreach (string item in cartas)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Equals("") == true)
                {
                    break;
                }
                Panel img = new Panel();

                Label lblValorCarta = new Label();
                Label lblQuantidadeBode = new Label();
                img.Size = new Size(140, 165);

                string[] carta = EncontrarCarta(item.Split(','), 0);

                if (carta == null)
                {
                    string verificarVez = Jogo.VerificarVez(idPartida);

                    string retorno = Jogo.ListarPartidas("E");
                    retorno = retorno.Replace("\r", "");
                    retorno = retorno.Substring(0, retorno.Length - 1);
                    string[] partidas = retorno.Split('\n');

                    foreach (string partida in partidas)
                    {
                        string[] iten = partida.Split(',');
                        if (idPartida == Int32.Parse(iten[0]))
                        {
                            string historico = Jogo.ExibirNarracao(idPartida).Replace('\r', ' ').Trim();
                            string[] fimJogo = historico.Split('\n');
                            MessageBox.Show($"Partida Finalizada \n {fimJogo[0]}");
                            break;
                        }
                    }
                }
                else if (carta[2] != null)
                {
                    img.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("b" + carta[2].Trim());
                    lblValorCarta.Text = carta[0];
                    lblQuantidadeBode.Text = carta[1];
                }

                img.Location = new Point(x, y);
                lblValorCarta.Location = new Point(x + 20, y + 10);
                lblValorCarta.AutoSize = true;
                lblValorCarta.Font = new Font(nomeFont, tamanhoFont);
                lblValorCarta.ForeColor = Color.Black;



                lblQuantidadeBode.Location = new Point(x + 20, img.Height - 10);
                lblQuantidadeBode.AutoSize = true;
                lblQuantidadeBode.Font = new Font(nomeFont, tamanhoFont);
                lblQuantidadeBode.ForeColor = Color.Black;


                img.BackgroundImageLayout = ImageLayout.Stretch;

                x += img.Width + 10;
                alturaMax = img.Height;
                if (x > pnlMao.Width - 100)
                {
                    x = 20;
                    y += alturaMax + 10;
                }

                panel.Controls.Add(lblQuantidadeBode);
                panel.Controls.Add(lblValorCarta);
                panel.Controls.Add(img);
            }
        }

        private void btnVerificarMesa_Click(object sender, EventArgs e)
        {
            verMesa = Jogo.VerificarMesa(idPartida);
            verMesa = verMesa.Replace("\r", "");
            verMesa = verMesa.Trim();
            string[] mesa = verMesa.Split('\n');

            Ultima = new string[4];
            string[] cartasMesa = new string[4];
            int i = 0;
            bool desenharMesa = false;
            foreach (string carta in mesa)
            {
                if (carta.Contains('I'))
                {
                    string tamanhoIlha = carta;

                }
                if (carta.Contains(","))
                {
                    desenharMesa = true;
                    string[] bode = carta.Split(',');
                    string[] cartaBode = EncontrarCarta(bode, 1);
                    string auxCarta = "";
                    int cont = 0;
                    foreach (string elemento in cartaBode)
                    {
                        if (cont < 2)
                        {
                            auxCarta += elemento + ",";
                            cont++;
                        }
                        else
                        {
                            auxCarta += elemento;
                        }
                    }
                    cartasMesa[i] = auxCarta;
                    i++;
                }
            }

            int contador = 0;
            foreach (string item in cartasMesa)
            {

                if (item == null || Ultima[contador] == null)
                {
                    if (item != Ultima[contador])
                    {
                        desenharMesa = true;
                    }
                    break;
                }

                if (Ultima[contador].Equals(item))
                {
                    desenharMesa = false;
                }

                contador++;
            }


            if (desenharMesa == true)
            {
                mostrarCarta(cartasMesa, pnlMesa);
                Ultima = cartasMesa;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEntrarPartida entrar = new frmEntrarPartida();
            entrar.Show();
            this.Close();
        }

        private void btnVerificarIlha_Click(object sender, EventArgs e)
        {
            verMesa = Jogo.VerificarMesa(idPartida);
            string[] verIlha = verMesa.Split(',');
            string valorIlha = verIlha[0];
            lblTamanho.Text = valorIlha;
        }
    }
}
