using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_07_SuperCajero
{
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private WebClient wc = new WebClient();
        private int p50 = 0;
        private int p100 = 0;
        private int p200 = 0;
        private int p500 = 0;
        private int p1000 = 0;
        private int p2000 = 0;
        private int billetes50 = 0;
        private int billetes100 = 0;
        private int billetes200 = 0;
        private int billetes500 = 0;
        private int billetes1000 = 0;
        private int billetes2000 = 0;
        private int resultado = 0;
        private string retiroString;

        private void _Retiro()
        {
            try
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                retiroString = wc.UploadString("http://adamix.net/api/cajero/retiro?id=" + Datos.ID + "&clave=" + Datos.Clave + "&matricula=20186554&monto=" + resultado + "", resultado.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
                resultado = 0;
                l_money.Text = resultado.ToString();
            }
            resultado = 0;
            l_money.Text = resultado.ToString();
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;

            if (resultado < 100 || resultado >= 2000)
            {
                MessageBox.Show("No puede Retirar menos de 100$ Pesos o más de 2000$ Pesos😢",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Emoji_2.Visible = true;
                if (Emoji_1.Visible == true)
                {
                    Emoji_1.Visible = false;
                }
            }
            else
            {
                _Retiro();
            }

            // Siguiente
            if (retiroString == null)
            {
                Emoji_2.Visible = true;
                if (Emoji_1.Visible == true)
                {
                    Emoji_1.Visible = false;
                }
                MessageBox.Show("Error al Conectarse al Servidor y/o proveedor",
                    "Error con el Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Emoji_2.Visible == true)
                {
                    Emoji_2.Visible = false;
                }
                else
                {
                    Emoji_1.Visible = true;
                    _Show();
                    Export();
                }
            }
        }

        private void Export()
        {
            try
            {
                string content = retiroString + Environment.NewLine +
                                 "Usted a Retirado " + resultado + "$ Pesos" + Environment.NewLine + Environment.NewLine +
                                 "Cicuenta Pesos 50$: " + p50 + Environment.NewLine +
                                 "Cien Pesos 100$: " + p100 + Environment.NewLine +
                                 "Doscientos Pesos 200$: " + p200 + Environment.NewLine +
                                 "Quinietos Pesos 500$: " + p500 + Environment.NewLine +
                                 "Mil Pesos 1000$: " + p1000 + Environment.NewLine +
                                 "Dos Mill Pesos 2000$: " + p2000 + Environment.NewLine;
                string filename = @"Documentación_Retiro.txt";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                using (FileStream stream = File.Create(filename, 500000))
                {
                    byte[] title = new UTF8Encoding(true).GetBytes(content);
                    stream.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes(Environment.NewLine + "Att: Victor Rosario 👌 2018-6554");
                    stream.Write(author, 0, author.Length);
                }
                File.WriteAllText(filename, content);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void _Show()
        {
            Clear();
            string content = retiroString + Environment.NewLine +
                                 "Usted a Retirado " + resultado + "$ Pesos" + Environment.NewLine + Environment.NewLine +
                                 "Cicuenta Pesos 50$: " + p50 + Environment.NewLine +
                                 "Cien Pesos 100$: " + p100 + Environment.NewLine +
                                 "Doscientos Pesos 200$: " + p200 + Environment.NewLine +
                                 "Quinietos Pesos 500$: " + p500 + Environment.NewLine +
                                 "Mil Pesos 1000$: " + p1000 + Environment.NewLine +
                                 "Dos Mill Pesos 2000$: " + p2000 + Environment.NewLine + Environment.NewLine +
                                 "Att: Victor Rosario 👌 2018-6554";
            Label Content = new Label();
            Content.Text = content;
            Content.Top = 10;
            Content.Height = 400;
            Content.Width = 600;
            Content.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            P_Contenedor.Controls.Add(Content);
        }

        private void Clear()
        {
            while(P_Contenedor.Controls.Count > 1)
            {
                P_Contenedor.Controls.RemoveAt(0);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.ShowDialog();
        }

        private void bt_50_Click(object sender, EventArgs e)
        {
            p50++;
            billetes50 += 50;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void bt_100_Click(object sender, EventArgs e)
        {
            p100++;
            billetes100 += 100;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void bt_200_Click(object sender, EventArgs e)
        {
            p200++;
            billetes200 += 200;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void bt_500_Click(object sender, EventArgs e)
        {
            p500++;
            billetes500 += 500;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void bt_1000_Click(object sender, EventArgs e)
        {
            p1000++;
            billetes1000 += 1000;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void bt_2000_Click(object sender, EventArgs e)
        {
            p2000++;
            billetes2000 += 2000;
            resultado = billetes50 + billetes100 + billetes200 + billetes500 + billetes1000 + billetes2000;
            l_money.Text = resultado.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}