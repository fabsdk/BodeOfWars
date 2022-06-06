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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmEntrarPartida entrar = new frmEntrarPartida();
            entrar.Show();
        }
    }
}
