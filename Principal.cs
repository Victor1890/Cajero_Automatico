using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_07_SuperCajero
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDeposito_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.ShowDialog();
            this.Close();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.ShowDialog();
            this.Close();
        }

        private void btRetiro_Click(object sender, EventArgs e)
        {
            this.Close();
            Retiro retiro = new Retiro();
            retiro.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
