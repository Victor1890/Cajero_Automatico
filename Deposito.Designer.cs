namespace Tarea_07_SuperCajero
{
    partial class Deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            this.Salir = new System.Windows.Forms.Button();
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.Emoji_1 = new System.Windows.Forms.PictureBox();
            this.Emoji_2 = new System.Windows.Forms.PictureBox();
            this.btDepositar = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lineas = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.Grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(1352, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(33, 27);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "X";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Grupo
            // 
            this.Grupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grupo.Controls.Add(this.Emoji_1);
            this.Grupo.Controls.Add(this.Emoji_2);
            this.Grupo.Controls.Add(this.btDepositar);
            this.Grupo.Controls.Add(this.lUsuario);
            this.Grupo.Controls.Add(this.tbMonto);
            this.Grupo.Controls.Add(this.label2);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Controls.Add(this.Lineas);
            this.Grupo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Grupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grupo.Location = new System.Drawing.Point(167, 160);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(1055, 551);
            this.Grupo.TabIndex = 7;
            this.Grupo.TabStop = false;
            this.Grupo.Text = "Deposito";
            // 
            // Emoji_1
            // 
            this.Emoji_1.Image = ((System.Drawing.Image)(resources.GetObject("Emoji_1.Image")));
            this.Emoji_1.Location = new System.Drawing.Point(255, 315);
            this.Emoji_1.Name = "Emoji_1";
            this.Emoji_1.Size = new System.Drawing.Size(63, 61);
            this.Emoji_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji_1.TabIndex = 22;
            this.Emoji_1.TabStop = false;
            this.Emoji_1.Visible = false;
            // 
            // Emoji_2
            // 
            this.Emoji_2.Image = ((System.Drawing.Image)(resources.GetObject("Emoji_2.Image")));
            this.Emoji_2.Location = new System.Drawing.Point(186, 315);
            this.Emoji_2.Name = "Emoji_2";
            this.Emoji_2.Size = new System.Drawing.Size(63, 61);
            this.Emoji_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji_2.TabIndex = 21;
            this.Emoji_2.TabStop = false;
            this.Emoji_2.Visible = false;
            // 
            // btDepositar
            // 
            this.btDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDepositar.Location = new System.Drawing.Point(661, 223);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(246, 92);
            this.btDepositar.TabIndex = 20;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(729, 116);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(103, 34);
            this.lUsuario.TabIndex = 19;
            this.lUsuario.Text = "Monto";
            // 
            // tbMonto
            // 
            this.tbMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.tbMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMonto.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.ForeColor = System.Drawing.Color.White;
            this.tbMonto.Location = new System.Drawing.Point(655, 153);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(252, 41);
            this.tbMonto.TabIndex = 17;
            this.tbMonto.Click += new System.EventHandler(this.tbMonto_Click);
            this.tbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Victor Rosario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cajéro Automatico";
            // 
            // Lineas
            // 
            this.Lineas.AutoSize = true;
            this.Lineas.Location = new System.Drawing.Point(522, 68);
            this.Lineas.Name = "Lineas";
            this.Lineas.Size = new System.Drawing.Size(13, 418);
            this.Lineas.TabIndex = 11;
            this.Lineas.Text = "l\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl";
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(1108, 107);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(114, 56);
            this.btBack.TabIndex = 22;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1388, 870);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposito";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito";
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lineas;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.PictureBox Emoji_1;
        private System.Windows.Forms.PictureBox Emoji_2;
        private System.Windows.Forms.Button btBack;
    }
}