
namespace chocoflantastico
{
    partial class FormGeneralRoot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).BeginInit();
            this.gbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(114)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 55);
            this.panel1.TabIndex = 0;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::chocoflantastico.Properties.Resources.windowclose_104378;
            this.pbCerrar.Location = new System.Drawing.Point(1135, 10);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(29, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 4;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::chocoflantastico.Properties.Resources.windowminimize_104316;
            this.pbMinimizar.Location = new System.Drawing.Point(1097, 10);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(29, 30);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 3;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(119, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 27);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::chocoflantastico.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(68, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlForm.Controls.Add(this.gbUsuarios);
            this.pnlForm.Controls.Add(this.btnCerrarSesion);
            this.pnlForm.Controls.Add(this.pbCerrarSesion);
            this.pnlForm.Controls.Add(this.gbReporte);
            this.pnlForm.Controls.Add(this.gbInventario);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.lblFecha);
            this.pnlForm.Controls.Add(this.lblHora);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 55);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1180, 610);
            this.pnlForm.TabIndex = 2;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.pictureBox4);
            this.gbUsuarios.Controls.Add(this.btnUsers);
            this.gbUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.gbUsuarios.Location = new System.Drawing.Point(331, 412);
            this.gbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.gbUsuarios.Size = new System.Drawing.Size(508, 138);
            this.gbUsuarios.TabIndex = 15;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "USUARIOS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::chocoflantastico.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(39, 37);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.btnUsers.Location = new System.Drawing.Point(265, 60);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(192, 46);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "ENTRAR";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(32)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(1024, 560);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(139, 33);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // pbCerrarSesion
            // 
            this.pbCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarSesion.Image = global::chocoflantastico.Properties.Resources.logout_1_icon_icons_com_64965;
            this.pbCerrarSesion.Location = new System.Drawing.Point(988, 560);
            this.pbCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarSesion.Name = "pbCerrarSesion";
            this.pbCerrarSesion.Size = new System.Drawing.Size(29, 33);
            this.pbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrarSesion.TabIndex = 16;
            this.pbCerrarSesion.TabStop = false;
            this.pbCerrarSesion.Click += new System.EventHandler(this.pbCerrarSesion_Click_1);
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.pictureBox3);
            this.gbReporte.Controls.Add(this.btnReporte);
            this.gbReporte.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.gbReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.gbReporte.Location = new System.Drawing.Point(596, 71);
            this.gbReporte.Margin = new System.Windows.Forms.Padding(4);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Padding = new System.Windows.Forms.Padding(4);
            this.gbReporte.Size = new System.Drawing.Size(467, 295);
            this.gbReporte.TabIndex = 15;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "REPORTES";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::chocoflantastico.Properties.Resources.reporte;
            this.pictureBox3.Location = new System.Drawing.Point(85, 66);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(340, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.btnReporte.Location = new System.Drawing.Point(121, 213);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(272, 57);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "ENTRAR";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.pictureBox1);
            this.gbInventario.Controls.Add(this.btnInventario);
            this.gbInventario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.gbInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.gbInventario.Location = new System.Drawing.Point(65, 71);
            this.gbInventario.Margin = new System.Windows.Forms.Padding(4);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Padding = new System.Windows.Forms.Padding(4);
            this.gbInventario.Size = new System.Drawing.Size(467, 295);
            this.gbInventario.TabIndex = 14;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chocoflantastico.Properties.Resources.inv;
            this.pictureBox1.Location = new System.Drawing.Point(56, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.btnInventario.Location = new System.Drawing.Point(97, 213);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(272, 57);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "ENTRAR";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha y Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(32)))));
            this.lblFecha.Location = new System.Drawing.Point(159, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(16, 19);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(32)))));
            this.lblHora.Location = new System.Drawing.Point(327, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(16, 19);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "-";
            // 
            // FormGeneralRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 665);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGeneralRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGeneralRoot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.gbUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).EndInit();
            this.gbReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReporte;
        public System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pbCerrarSesion;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnUsers;
    }
}