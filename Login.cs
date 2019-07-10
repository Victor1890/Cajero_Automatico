using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace Tarea_07_SuperCajero
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        Principal principal = new Principal();
        WebClient wc = new WebClient();
        private string Datos_API;


        private void Agregar()
        {
            Datos.Usuario = tbUsuario.Text.Trim();
            Datos.Clave = tbClave.Text.Trim();
        }

        private void _Login()
        {
            try
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                Datos_API = wc.DownloadString("http://adamix.net/api/cajero/login?usuario=" + Datos.Usuario + "&clave=" + Datos.Clave);
                var vs = Convert.ToString(Datos_API[0]);
                Datos.ID = int.Parse(vs);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Agregar();
            if (Datos.Usuario == "" || Datos.Clave == "")
            {
                MessageBox.Show("Trate de Llenar todos los Campos",
                    "Campos Vacio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Emoji_2.Visible = true;
                if (Emoji_1.Visible == true)
                {
                    Emoji_1.Visible = false;
                }
                FieldClean();
            }
            else
            {
                _Login();
                if (Datos_API == null)
                {
                    MessageBox.Show("Error a Conectarse al Internet",
                        "Error con la Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FieldClean();
                    Emoji_2.Visible = true;
                    if (Emoji_1.Visible == true)
                    {
                        Emoji_1.Visible = false;
                    }
                }
                else if (Datos_API == "Login No valido")
                {
                    MessageBox.Show("El Usuario y Contraseña no son Validos",
                        "Error con la Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FieldClean();
                    Emoji_2.Visible = true;
                    if (Emoji_1.Visible == true)
                    {
                        Emoji_1.Visible = false;
                    }
                }
                else
                {
                    if (Emoji_2.Visible == true)
                    {
                        Emoji_2.Visible = false;
                    }
                    Emoji_1.Visible = true;
                    
                    FieldClean();
                    System.Threading.Thread.Sleep(999);
                    principal.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Check_Pass_Click(object sender, EventArgs e)
        {
            Passwork();
        }

        /// <summary>
        /// Este Código no se podrá usar por el momento
        /// Resulta que en estos momentos estoy trabajando con otras partes del código
        /// </summary>
        private void Passwork()
        {
            if(tbClave.PasswordChar != '*')
            {
                tbClave.PasswordChar = '*';
            }
            else
            {
                tbClave.PasswordChar = '\0';
            }
        }

        private void FieldClean()
        {
            tbUsuario.Clear();
            tbClave.Clear();
        }

        public void Call_Keyboard()
        {
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void alert(string mng)
        {
            MessageBox.Show(mng);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUsuario_Click(object sender, EventArgs e)
        {
            Call_Keyboard();
        }
    }
}