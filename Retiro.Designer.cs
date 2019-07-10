namespace Tarea_07_SuperCajero
{
    partial class Retiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retiro));
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.btRetirar = new System.Windows.Forms.Button();
            this.l_money = new System.Windows.Forms.Label();
            this.P_Contenedor = new System.Windows.Forms.Panel();
            this.bt_1000 = new System.Windows.Forms.Button();
            this.bt_2000 = new System.Windows.Forms.Button();
            this.bt_500 = new System.Windows.Forms.Button();
            this.bt_100 = new System.Windows.Forms.Button();
            this.bt_50 = new System.Windows.Forms.Button();
            this.bt_200 = new System.Windows.Forms.Button();
            this.Emoji_1 = new System.Windows.Forms.PictureBox();
            this.Emoji_2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lineas = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grupo.Controls.Add(this.btRetirar);
            this.Grupo.Controls.Add(this.l_money);
            this.Grupo.Controls.Add(this.P_Contenedor);
            this.Grupo.Controls.Add(this.bt_1000);
            this.Grupo.Controls.Add(this.bt_2000);
            this.Grupo.Controls.Add(this.bt_500);
            this.Grupo.Controls.Add(this.bt_100);
            this.Grupo.Controls.Add(this.bt_50);
            this.Grupo.Controls.Add(this.bt_200);
            this.Grupo.Controls.Add(this.Emoji_1);
            this.Grupo.Controls.Add(this.Emoji_2);
            this.Grupo.Controls.Add(this.label2);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Controls.Add(this.Lineas);
            this.Grupo.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.Grupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grupo.Location = new System.Drawing.Point(129, 122);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(1055, 551);
            this.Grupo.TabIndex = 8;
            this.Grupo.TabStop = false;
            this.Grupo.Text = "Retiro";
            // 
            // btRetirar
            // 
            this.btRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetirar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetirar.Location = new System.Drawing.Point(482, 211);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(142, 106);
            this.btRetirar.TabIndex = 31;
            this.btRetirar.Text = "Retirar";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // l_money
            // 
            this.l_money.AutoSize = true;
            this.l_money.BackColor = System.Drawing.Color.Transparent;
            this.l_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_money.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_money.Location = new System.Drawing.Point(948, 15);
            this.l_money.Name = "l_money";
            this.l_money.Size = new System.Drawing.Size(107, 39);
            this.l_money.TabIndex = 30;
            this.l_money.Text = "00000";
            this.l_money.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // P_Contenedor
            // 
            this.P_Contenedor.Location = new System.Drawing.Point(24, 247);
            this.P_Contenedor.Name = "P_Contenedor";
            this.P_Contenedor.Size = new System.Drawing.Size(373, 239);
            this.P_Contenedor.TabIndex = 29;
            // 
            // bt_1000
            // 
            this.bt_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_1000.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_1000.Image = ((System.Drawing.Image)(resources.GetObject("bt_1000.Image")));
            this.bt_1000.Location = new System.Drawing.Point(796, 286);
            this.bt_1000.Name = "bt_1000";
            this.bt_1000.Size = new System.Drawing.Size(120, 184);
            this.bt_1000.TabIndex = 28;
            this.bt_1000.Text = "1000";
            this.bt_1000.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_1000.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_1000.UseVisualStyleBackColor = true;
            this.bt_1000.Click += new System.EventHandler(this.bt_1000_Click);
            // 
            // bt_2000
            // 
            this.bt_2000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_2000.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_2000.Image = ((System.Drawing.Image)(resources.GetObject("bt_2000.Image")));
            this.bt_2000.Location = new System.Drawing.Point(670, 286);
            this.bt_2000.Name = "bt_2000";
            this.bt_2000.Size = new System.Drawing.Size(120, 184);
            this.bt_2000.TabIndex = 27;
            this.bt_2000.Text = "2000";
            this.bt_2000.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_2000.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_2000.UseVisualStyleBackColor = true;
            this.bt_2000.Click += new System.EventHandler(this.bt_2000_Click);
            // 
            // bt_500
            // 
            this.bt_500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_500.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_500.Image = ((System.Drawing.Image)(resources.GetObject("bt_500.Image")));
            this.bt_500.Location = new System.Drawing.Point(922, 286);
            this.bt_500.Name = "bt_500";
            this.bt_500.Size = new System.Drawing.Size(120, 184);
            this.bt_500.TabIndex = 26;
            this.bt_500.Text = "500";
            this.bt_500.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_500.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_500.UseVisualStyleBackColor = true;
            this.bt_500.Click += new System.EventHandler(this.bt_500_Click);
            // 
            // bt_100
            // 
            this.bt_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_100.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_100.Image = ((System.Drawing.Image)(resources.GetObject("bt_100.Image")));
            this.bt_100.Location = new System.Drawing.Point(796, 92);
            this.bt_100.Name = "bt_100";
            this.bt_100.Size = new System.Drawing.Size(120, 184);
            this.bt_100.TabIndex = 25;
            this.bt_100.Text = "100";
            this.bt_100.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_100.UseVisualStyleBackColor = true;
            this.bt_100.Click += new System.EventHandler(this.bt_100_Click);
            // 
            // bt_50
            // 
            this.bt_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_50.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_50.Image = ((System.Drawing.Image)(resources.GetObject("bt_50.Image")));
            this.bt_50.Location = new System.Drawing.Point(670, 92);
            this.bt_50.Name = "bt_50";
            this.bt_50.Size = new System.Drawing.Size(120, 184);
            this.bt_50.TabIndex = 24;
            this.bt_50.Text = "50";
            this.bt_50.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_50.UseVisualStyleBackColor = true;
            this.bt_50.Click += new System.EventHandler(this.bt_50_Click);
            // 
            // bt_200
            // 
            this.bt_200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_200.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.bt_200.Image = ((System.Drawing.Image)(resources.GetObject("bt_200.Image")));
            this.bt_200.Location = new System.Drawing.Point(922, 92);
            this.bt_200.Name = "bt_200";
            this.bt_200.Size = new System.Drawing.Size(120, 184);
            this.bt_200.TabIndex = 23;
            this.bt_200.Text = "200";
            this.bt_200.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_200.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_200.UseVisualStyleBackColor = true;
            this.bt_200.Click += new System.EventHandler(this.bt_200_Click);
            // 
            // Emoji_1
            // 
            this.Emoji_1.Image = ((System.Drawing.Image)(resources.GetObject("Emoji_1.Image")));
            this.Emoji_1.Location = new System.Drawing.Point(215, 166);
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
            this.Emoji_2.Location = new System.Drawing.Point(146, 166);
            this.Emoji_2.Name = "Emoji_2";
            this.Emoji_2.Size = new System.Drawing.Size(63, 61);
            this.Emoji_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji_2.TabIndex = 21;
            this.Emoji_2.TabStop = false;
            this.Emoji_2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 127);
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
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cajéro Automatico";
            // 
            // Lineas
            // 
            this.Lineas.AutoSize = true;
            this.Lineas.Location = new System.Drawing.Point(423, 20);
            this.Lineas.Name = "Lineas";
            this.Lineas.Size = new System.Drawing.Size(17, 525);
            this.Lineas.TabIndex = 11;
            this.Lineas.Text = "l\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl";
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
            this.btBack.Location = new System.Drawing.Point(1070, 69);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(114, 56);
            this.btBack.TabIndex = 22;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(1275, 2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(33, 27);
            this.Salir.TabIndex = 23;
            this.Salir.Text = "X";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1312, 794);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.Grupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Retiro";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro";
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.Panel P_Contenedor;
        private System.Windows.Forms.Button bt_1000;
        private System.Windows.Forms.Button bt_2000;
        private System.Windows.Forms.Button bt_500;
        private System.Windows.Forms.Button bt_100;
        private System.Windows.Forms.Button bt_50;
        private System.Windows.Forms.Button bt_200;
        private System.Windows.Forms.PictureBox Emoji_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lineas;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label l_money;
        private System.Windows.Forms.Button btRetirar;
        private System.Windows.Forms.PictureBox Emoji_2;
    }
}