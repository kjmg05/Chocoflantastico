﻿namespace chocoflantastico
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlForm.SuspendLayout();
            this.gbState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlForm.Controls.Add(this.cmbRol);
            this.pnlForm.Controls.Add(this.lblRol);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.lblPassword);
            this.pnlForm.Controls.Add(this.txtUsuario);
            this.pnlForm.Controls.Add(this.lblUsername);
            this.pnlForm.Controls.Add(this.gbState);
            this.pnlForm.Controls.Add(this.btnModificar);
            this.pnlForm.Controls.Add(this.btnInhabilitar);
            this.pnlForm.Controls.Add(this.btnGuardar);
            this.pnlForm.Controls.Add(this.dgvUsers);
            this.pnlForm.Controls.Add(this.btnCerrarSesion);
            this.pnlForm.Controls.Add(this.pbCerrarSesion);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.lblFecha);
            this.pnlForm.Controls.Add(this.lblHora);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 55);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1180, 610);
            this.pnlForm.TabIndex = 4;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(301, 241);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(257, 27);
            this.cmbRol.TabIndex = 62;
            this.cmbRol.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRol_Validating);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.DimGray;
            this.lblRol.Location = new System.Drawing.Point(86, 244);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 19);
            this.lblRol.TabIndex = 61;
            this.lblRol.Text = "Rol:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(301, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 28);
            this.txtPassword.TabIndex = 60;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(86, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 19);
            this.lblPassword.TabIndex = 59;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(301, 92);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 28);
            this.txtUsuario.TabIndex = 58;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(86, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 19);
            this.lblUsername.TabIndex = 56;
            this.lblUsername.Text = "Usuario:";
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.rbHabilitado);
            this.gbState.Controls.Add(this.rbInhabilitado);
            this.gbState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbState.Location = new System.Drawing.Point(90, 317);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(463, 71);
            this.gbState.TabIndex = 54;
            this.gbState.TabStop = false;
            this.gbState.Text = "Estado";
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.Checked = true;
            this.rbHabilitado.Location = new System.Drawing.Point(61, 32);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(113, 23);
            this.rbHabilitado.TabIndex = 1;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = true;
            // 
            // rbInhabilitado
            // 
            this.rbInhabilitado.AutoSize = true;
            this.rbInhabilitado.Location = new System.Drawing.Point(255, 32);
            this.rbInhabilitado.Name = "rbInhabilitado";
            this.rbInhabilitado.Size = new System.Drawing.Size(126, 23);
            this.rbInhabilitado.TabIndex = 0;
            this.rbInhabilitado.Text = "Inhabilitado";
            this.rbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(90, 461);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 41);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(261, 461);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 41);
            this.btnInhabilitar.TabIndex = 52;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(422, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 41);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 29;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvUsers.Location = new System.Drawing.Point(639, 53);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(424, 469);
            this.dgvUsers.TabIndex = 50;
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
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.panel1.TabIndex = 3;
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
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            this.errorProviderApp.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderApp.Icon")));
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 665);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        public System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pbCerrarSesion;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbState;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbInhabilitado;
        private System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}