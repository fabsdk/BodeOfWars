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
    public partial class frmEntrarPartida : Form
    {
        int idPartida { get; set; }
        int idJogador { get; set; }
        string senha { get; set; }
        string senhaJogador { get; set; }

        public frmEntrarPartida()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            if (lstListarPartidas == null)
            {
                MessageBox.Show("Nenhuma partida foi selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstListarPartidas.Items.Clear();
                string retorno = Jogo.ListarPartidas("T");
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                string[] partidas = retorno.Split('\n');

                for (int i = 0; i < partidas.Length; i++)
                {
                    lstListarPartidas.Items.Add(partidas[i]);
                }
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            Jogo.CriarPartida(nomePartida, senhaPartida);

            if (txtNomePartida.Text == "" || txtSenhaPartida.Text == "")
            {
                MessageBox.Show("Nome da partida e/ou Senha vazios, por favor inserir!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string currPartida;

            if (lstListarPartidas.SelectedItem == null)
            {
                MessageBox.Show("Nenhuma partida foi selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                currPartida = lstListarPartidas.SelectedItem.ToString();
            }

            string[] Partidas = currPartida.Split(',');
            idPartida = Int32.Parse(Partidas[0]);
            string nome = txtNomeJogador.Text;
            senha = txtSenhaPartida.Text;
            string entrarPartida = Jogo.EntrarPartida(idPartida, nome, senha);

            string[] jogadores = entrarPartida.Split(',');
            idJogador = Int32.Parse(jogadores[0]);
            senhaJogador = jogadores[1];

            if (entrarPartida.Contains("ERRO: "))
            {
                MessageBox.Show(entrarPartida, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                MessageBox.Show("Entrada com sucesso!");
            }

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (lstListarPartidas.SelectedItem != null)
            {
                string currPartida;
                currPartida = lstListarPartidas.SelectedItem.ToString();
                string[] Partidas = currPartida.Split(',');
                string jogadores = Jogo.ListarJogadores(idPartida);
                txtListarJogadores.Text = jogadores;

            }
            else
            {
                MessageBox.Show("Nenhuma partida foi escolhida", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmJogarManual jogarM = new frmJogarManual();
            jogarM.idPartida = idPartida; 
            jogarM.idJogador = idJogador;
            jogarM.senhaJogador = senhaJogador;
            jogarM.Show();
            this.Close();
            
        }

        private void btnEstrategia_Click(object sender, EventArgs e)
        {
            frmJogarAutonomo jogarA = new frmJogarAutonomo();
            jogarA.idPartida = idPartida;
            jogarA.idJogador = idJogador;
            jogarA.senhaJogador = senhaJogador;
            jogarA.Show();
            this.Close();
        }
    }
}
