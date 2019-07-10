using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace Tarea_07_SuperCajero
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private WebClient wc = new WebClient();
        
        private string consultaString;

        private void _Consulta()
        {
            try
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                consultaString = wc.DownloadString("http://adamix.net/api/cajero/consulta_balance?id=" + Datos.ID + "&clave=" + Datos.Clave + "&matricula=20186554");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            _Consulta();
            if (consultaString == null)
            {
                MessageBox.Show("Actualmente usted tiene problema con su internet",
                    "Error 502", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Emoji_1.Visible == true)
                {
                    Emoji_1.Visible = false;
                }
                Emoji_2.Visible = true;
            }
            else
            {
                Emoji_1.Visible = true;
                if(Emoji_2.Visible == true)
                {
                    Emoji_2.Visible = false;
                }
                Export();
                Export();
            }
        }

        private void _Show()
        {
            Label label = new Label();
            label.Text = @"Usted Actualmente tiene " + Environment.NewLine +
                consultaString + "$ Pesos ✔";
            label.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            label.Width = 400;
            label.Height = 600;
            label.Top = 10;
            label.ForeColor = Color.White;
            Contenido.Controls.Add(label);
        }

        private void Export()
        {
            try
            {
                string content = @"Usted Actualmente tiene " + Environment.NewLine +
                    consultaString + " $ Pesos ✔";
                string filename = @"Documentación_Consulta.txt";
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

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.ShowDialog();
        }
    }
}
