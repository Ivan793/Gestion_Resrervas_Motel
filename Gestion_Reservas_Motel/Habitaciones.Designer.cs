using System;

namespace Gestion_Reservas_Motel
{
    partial class Habitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habitaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblReservas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbNotredame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotredame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHabitaciones.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.ForeColor = System.Drawing.Color.Black;
            this.lblHabitaciones.Location = new System.Drawing.Point(38, 10);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(102, 18);
            this.lblHabitaciones.TabIndex = 16;
            this.lblHabitaciones.Text = "Habitaciones";
            this.lblHabitaciones.Click += new System.EventHandler(this.lblHabitaciones_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarios.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuarios.Location = new System.Drawing.Point(32, 263);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(75, 18);
            this.lblUsuarios.TabIndex = 23;
            this.lblUsuarios.Text = " Usuarios";
            this.lblUsuarios.Click += new System.EventHandler(this.lblUsuarios_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.lblCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategorias.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategorias.Location = new System.Drawing.Point(32, 216);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(90, 18);
            this.lblCategorias.TabIndex = 20;
            this.lblCategorias.Text = " Categorias";
            this.lblCategorias.Click += new System.EventHandler(this.lblCategorias_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.LightGray;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Black;
            this.lblClientes.Location = new System.Drawing.Point(35, 309);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(66, 18);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReservas.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReservas.Location = new System.Drawing.Point(35, 355);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(70, 18);
            this.lblReservas.TabIndex = 25;
            this.lblReservas.Text = "Reservas";
            this.lblReservas.Click += new System.EventHandler(this.lblReservas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblHabitaciones);
            this.panel2.Location = new System.Drawing.Point(-1, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 41);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.cbEstado);
            this.panelContenedor.Controls.Add(this.cbTipo);
            this.panelContenedor.Controls.Add(this.dgvHabitaciones);
            this.panelContenedor.Controls.Add(this.label9);
            this.panelContenedor.Controls.Add(this.btnEliminar);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.btnEditar);
            this.panelContenedor.Controls.Add(this.txtNombre);
            this.panelContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(141, 32);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Padding = new System.Windows.Forms.Padding(3);
            this.panelContenedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelContenedor.Size = new System.Drawing.Size(754, 544);
            this.panelContenedor.TabIndex = 28;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Mantenimiento"});
            this.cbEstado.Location = new System.Drawing.Point(348, 74);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 26);
            this.cbEstado.TabIndex = 11;
            this.cbEstado.Text = "Estado";
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(219, 74);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(108, 26);
            this.cbTipo.TabIndex = 10;
            this.cbTipo.Text = "Categoría";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // dgvHabitaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabitaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabitaciones.EnableHeadersVisualStyles = false;
            this.dgvHabitaciones.Location = new System.Drawing.Point(-1, 179);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.Size = new System.Drawing.Size(449, 364);
            this.dgvHabitaciones.TabIndex = 9;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellClick);
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            this.dgvHabitaciones.SelectionChanged += new System.EventHandler(this.dgvHabitaciones_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(422, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(279, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(134, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 36);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Location = new System.Drawing.Point(27, 67);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 33);
            this.txtNombre.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-1, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 30);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalir.Location = new System.Drawing.Point(13, 3);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(60, 18);
            this.lblSalir.TabIndex = 0;
            this.lblSalir.Text = "Logout";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            this.lblSalir.MouseEnter += new System.EventHandler(this.lblSalir_MouseEnter);
            this.lblSalir.MouseLeave += new System.EventHandler(this.lblSalir_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-1, 305);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-1, 351);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pbNotredame
            // 
            this.pbNotredame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNotredame.Image = global::Gestion_Reservas_Motel.Properties.Resources.notre_dame__1_;
            this.pbNotredame.Location = new System.Drawing.Point(-9, -7);
            this.pbNotredame.Name = "pbNotredame";
            this.pbNotredame.Size = new System.Drawing.Size(153, 155);
            this.pbNotredame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotredame.TabIndex = 0;
            this.pbNotredame.TabStop = false;
            this.pbNotredame.Click += new System.EventHandler(this.pbNotredame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administrar Habitaciones";
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(898, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbNotredame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotredame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox pbNotredame;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}