using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_07_SuperCajero
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        WebClient wc = new WebClient();
        

        private void _Deposito()
        {
            string monto = tbMonto.Text.TrimStart().TrimEnd().Trim().ToLower();
            
            if (monto == null)
            {
                MessageBox.Show("Tienes que llenar el Campo para poder Realizar la Acción",
                    "Llenar los Campos", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int _monto = int.Parse(monto);
                    if (_monto < 100)
                    {
                        Emoji_2.Visible = true;
                        if (Emoji_1.Visible == true)
                        {
                            Emoji_1.Visible = false;
                        }
                        MessageBox.Show("No puede Depositar menos de 100$ Pesos",
                            "Monto no Suficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        var depositoString = wc.UploadString("http://adamix.net/api/cajero/deposito?id=" + Datos.ID + "&clave="+ Datos.Clave +"&matricula=20186554&monto=" + monto + "", monto); ;
                        if (depositoString == "Deposito Correcto")
                        {
                            Emoji_1.Visible = true;
                            if (Emoji_2.Visible == true)
                            {
                                Emoji_2.Visible = false;
                            }
                        }
                        else if (_monto > 100)
                        {
                            Emoji_1.Visible = false;
                            if (Emoji_2.Visible == true)
                            {
                                Emoji_2.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error a Conectarse a Internet",
                        "Error 502", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            _Deposito();
            tbMonto.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.ShowDialog();
        }

        private void tbMonto_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Call_Keyboard();
        }
    }
}