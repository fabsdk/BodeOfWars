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
    public partial class frmJogarAutonomo : Form
    {
        public int idPartida { get; set; }
        public string senhaJogador { get; set; }
        public int idJogador { get; set; }

        private string[] cartasMao;

        private string[] cartasMesa;

        string iniciarPartida;

        private string verMesa;

        private int idRodada;

        private int vezJogador;

        string jogarIlhas;

        public frmJogarAutonomo()
        {
            InitializeComponent();
        }

        private void btnJogarPartida_Click(object sender, EventArgs e)
        {
            verificarMao();
            tmrJogar.Enabled = true;
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            começarPartida();
        }

        private void tmrJogar_Tick(object sender, EventArgs e)
        {

            tmrJogar.Enabled = false;
            jogarBode(cartasMesa);
            verficarVez();
            verificarMesa();
            verificarMao();
            mostrarHistorico();
            jogarIlha();
            verificarIlha();
            tmrJogar.Enabled = true;
        }

        public void começarPartida()
        {
            iniciarPartida = Jogo.IniciarPartida(idJogador, senhaJogador);

            if (iniciarPartida.Contains("ERRO"))
            {
                MessageBox.Show(iniciarPartida, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Partida iniciada com sucesso");
                verificarMao();
                verficarVez();
                tmrJogar.Enabled = true;
            }
        }

        private void verficarVez()
        {
            string vez = Jogo.VerificarVez(idPartida);
            txtVerificarVez.Text = vez;
        }
        private void verificarMao()
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

        private void verificarMesa()
        {
            verMesa = Jogo.VerificarMesa(idPartida);
            verMesa = verMesa.Replace("\r", "");
            verMesa = verMesa.Trim();
            string[] mesa = verMesa.Split('\n');

            string[] ultima = new string[4];
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
                    string[] cartaBode = encontrarCarta(bode, 1);
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

                if (item == null || ultima[contador] == null)
                {
                    if (item != ultima[contador])
                    {
                        desenharMesa = true;
                    }
                    break;
                }

                if (ultima[contador].Equals(item))
                {
                    desenharMesa = false;
                }

                contador++;
            }


            if (desenharMesa == true)
            {
                mostrarCarta(cartasMesa, pnlMesa);
                ultima = cartasMesa;
            }
        }

        private void mostrarHistorico()
        {
            txtHistorico.Text = Jogo.ExibirNarracao(idPartida);
        }
        private void jogarBode(string[] cartasMesa)
        {
            string verRodada = Jogo.VerificarVez(idPartida);
            string[] verificarRodada = verRodada.Split(',');
            idRodada = Int32.Parse(verificarRodada[2]);

            string verificarVez = Jogo.VerificarVez(idPartida);
            string[] partida = verificarVez.Split(',');

            if (partida[3].Contains("E") || partida[0].Contains("E"))
            {
                tmrJogar.Enabled = false;
            }
            else if (idRodada == 1 || idRodada == 2 || idRodada == 3 || idRodada == 4)
                Jogo.Jogar(idJogador, senhaJogador, Int32.Parse(cartasMao[0]));
            else if (idRodada == 5)
                Jogo.Jogar(idJogador, senhaJogador, Int32.Parse(cartasMao[3]));
            else if (idRodada == 6)
                Jogo.Jogar(idJogador, senhaJogador, Int32.Parse(cartasMao[1]));
            else if (idRodada == 7)
                Jogo.Jogar(idJogador, senhaJogador, Int32.Parse(cartasMao[0]));
            else if (idRodada == 8 && vezJogador == idJogador)
                Jogo.Jogar(idJogador, senhaJogador, Int32.Parse(cartasMao[0]));

        }

        private void verificarIlha()
        {
            verMesa = Jogo.VerificarMesa(idPartida);
            string[] verIlha = verMesa.Split(',');
            string valorIlha = verIlha[0];
            lblTamanho.Text = verMesa.Replace(valorIlha[0], ' ');
        }

        private void jogarIlha()
        {
            string tamanhos = Jogo.VerificarIlha(idJogador, senhaJogador);
            string verificarStatus = Jogo.VerificarVez(idPartida);
            verificarStatus = verificarStatus.Replace("\r", "");
            verificarStatus = verificarStatus.Replace("\n", "");
            string[] statusIlha = verificarStatus.Split(',');
            jogarIlhas = statusIlha[3];
            vezJogador = Int32.Parse(statusIlha[1]);

            if (jogarIlhas == "I" && vezJogador == idJogador)
            {
                string[] verificarTamanho = tamanhos.Split(',');
                int tamanhoIlha0 = Int32.Parse(verificarTamanho[0]);
                int tamanhoIlha1 = Int32.Parse(verificarTamanho[1]);

                if (tamanhoIlha0 > tamanhoIlha1)
                {
                    Jogo.DefinirIlha(idJogador, senhaJogador, tamanhoIlha1);
                    return;
                }
                else
                {
                    Jogo.DefinirIlha(idJogador, senhaJogador, tamanhoIlha0);
                    return;
                }

            }
        }

        private string[] encontrarCarta(string[] cartaMao, int idCarta)
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
                int valorMao = Int32.Parse(cartaMao[idCarta]);

                if (valorCarta == valorMao)
                {
                    return aux;
                }

            }
            return null;
        }

        private void mostrarCarta(string[] cartas, Panel panel)
        {
            int x = 5;
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
                img.Size = new Size(110, 165);

                string[] carta = encontrarCarta(item.Split(','), 0);

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
                                MessageBox.Show($"Parabéns :) \n {fimJogo[0]}");
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
                lblValorCarta.BackColor = Color.DeepSkyBlue;

                lblQuantidadeBode.Location = new Point(x + 20, img.Height - 10);
                lblQuantidadeBode.AutoSize = true;
                lblQuantidadeBode.Font = new Font(nomeFont, tamanhoFont);
                lblQuantidadeBode.ForeColor = Color.Black;
                lblQuantidadeBode.BackColor = Color.DeepSkyBlue;

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
    }
}
