namespace Tarea_07_SuperCajero
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Grupo_2 = new System.Windows.Forms.GroupBox();
            this.lTitulo2 = new System.Windows.Forms.Label();
            this.lTitulo1 = new System.Windows.Forms.Label();
            this.btRetiro = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btDeposito = new System.Windows.Forms.Button();
            this.Lineas = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.Grupo_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_2
            // 
            this.Grupo_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grupo_2.Controls.Add(this.lTitulo2);
            this.Grupo_2.Controls.Add(this.lTitulo1);
            this.Grupo_2.Controls.Add(this.btRetiro);
            this.Grupo_2.Controls.Add(this.btConsulta);
            this.Grupo_2.Controls.Add(this.btDeposito);
            this.Grupo_2.Controls.Add(this.Lineas);
            this.Grupo_2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Grupo_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grupo_2.Location = new System.Drawing.Point(117, 103);
            this.Grupo_2.Name = "Grupo_2";
            this.Grupo_2.Size = new System.Drawing.Size(1055, 551);
            this.Grupo_2.TabIndex = 0;
            this.Grupo_2.TabStop = false;
            this.Grupo_2.Text = "Pantalla Principal";
            // 
            // lTitulo2
            // 
            this.lTitulo2.AutoSize = true;
            this.lTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTitulo2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo2.Location = new System.Drawing.Point(159, 276);
            this.lTitulo2.Name = "lTitulo2";
            this.lTitulo2.Size = new System.Drawing.Size(190, 36);
            this.lTitulo2.TabIndex = 16;
            this.lTitulo2.Text = "Victor Rosario";
            // 
            // lTitulo1
            // 
            this.lTitulo1.AutoSize = true;
            this.lTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lTitulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTitulo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo1.Location = new System.Drawing.Point(85, 241);
            this.lTitulo1.Name = "lTitulo1";
            this.lTitulo1.Size = new System.Drawing.Size(332, 44);
            this.lTitulo1.TabIndex = 15;
            this.lTitulo1.Text = "Cajéro Automatico";
            // 
            // btRetiro
            // 
            this.btRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetiro.Location = new System.Drawing.Point(654, 356);
            this.btRetiro.Name = "btRetiro";
            this.btRetiro.Size = new System.Drawing.Size(246, 143);
            this.btRetiro.TabIndex = 14;
            this.btRetiro.Text = "Retiro";
            this.btRetiro.UseVisualStyleBackColor = true;
            this.btRetiro.Click += new System.EventHandler(this.btRetiro_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsulta.Location = new System.Drawing.Point(654, 207);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(246, 143);
            this.btConsulta.TabIndex = 13;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btDeposito
            // 
            this.btDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeposito.Location = new System.Drawing.Point(654, 56);
            this.btDeposito.Name = "btDeposito";
            this.btDeposito.Size = new System.Drawing.Size(246, 143);
            this.btDeposito.TabIndex = 12;
            this.btDeposito.Text = "Deposito";
            this.btDeposito.UseVisualStyleBackColor = true;
            this.btDeposito.Click += new System.EventHandler(this.btDeposito_Click);
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
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(1246, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(33, 27);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "X";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
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
            this.btBack.Location = new System.Drawing.Point(117, 41);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(114, 56);
            this.btBack.TabIndex = 23;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1284, 803);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Grupo_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Grupo_2.ResumeLayout(false);
            this.Grupo_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_2;
        private System.Windows.Forms.Button btRetiro;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btDeposito;
        private System.Windows.Forms.Label Lineas;
        private System.Windows.Forms.Label lTitulo2;
        private System.Windows.Forms.Label lTitulo1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btBack;
    }
}