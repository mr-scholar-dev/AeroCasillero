namespace AeroCasilleroProyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelForm = new Panel();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCasillero = new Label();
            txtCasillero = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnPaquetes = new Button();
            btnCasilleros = new Button();
            panelListado = new Panel();
            lblCantidad = new Label();
            dgvClientes = new DataGridView();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 36, 52);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(32, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AeroCasillero Proyecto";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.Gainsboro;
            lblSubtitulo.Location = new Point(35, 68);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(391, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Pantalla de prueba para clientes, BLL, DAL y arquitectura por capas";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(245, 247, 250);
            panelForm.Controls.Add(lblNombres);
            panelForm.Controls.Add(txtNombres);
            panelForm.Controls.Add(lblApellidos);
            panelForm.Controls.Add(txtApellidos);
            panelForm.Controls.Add(lblDocumento);
            panelForm.Controls.Add(txtDocumento);
            panelForm.Controls.Add(lblCorreo);
            panelForm.Controls.Add(txtCorreo);
            panelForm.Controls.Add(lblTelefono);
            panelForm.Controls.Add(txtTelefono);
            panelForm.Controls.Add(lblCasillero);
            panelForm.Controls.Add(txtCasillero);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(btnLimpiar);
            panelForm.Controls.Add(btnPaquetes);
            panelForm.Controls.Add(btnCasilleros);
            panelForm.Location = new Point(24, 144);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(420, 520);
            panelForm.TabIndex = 1;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombres.Location = new Point(22, 22);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(61, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(22, 40);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(370, 23);
            txtNombres.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidos.Location = new Point(22, 76);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(63, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(22, 94);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(370, 23);
            txtApellidos.TabIndex = 3;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(22, 130);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(121, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Cédula o Pasaporte";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(22, 148);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(370, 23);
            txtDocumento.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(22, 184);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(22, 202);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(370, 23);
            txtCorreo.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(22, 238);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 256);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(370, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCasillero.Location = new Point(22, 292);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(56, 15);
            lblCasillero.TabIndex = 10;
            lblCasillero.Text = "Casillero";
            // 
            // txtCasillero
            // 
            txtCasillero.Location = new Point(22, 310);
            txtCasillero.Name = "txtCasillero";
            txtCasillero.Size = new Size(370, 23);
            txtCasillero.TabIndex = 11;
            txtCasillero.PlaceholderText = "Ej. CAS-001";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(22, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 42);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(236, 240, 241);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(44, 62, 80);
            btnLimpiar.Location = new Point(222, 370);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 42);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnPaquetes
            // 
            btnPaquetes.BackColor = Color.FromArgb(155, 89, 182);
            btnPaquetes.FlatStyle = FlatStyle.Flat;
            btnPaquetes.ForeColor = Color.White;
            btnPaquetes.Location = new Point(22, 430);
            btnPaquetes.Name = "btnPaquetes";
            btnPaquetes.Size = new Size(370, 42);
            btnPaquetes.TabIndex = 14;
            btnPaquetes.Text = "Abrir registro de paquetes";
            btnPaquetes.UseVisualStyleBackColor = false;
            btnPaquetes.Click += btnPaquetes_Click;
            // 
            // btnCasilleros
            // 
            btnCasilleros.BackColor = Color.FromArgb(241, 196, 15);
            btnCasilleros.FlatStyle = FlatStyle.Flat;
            btnCasilleros.ForeColor = Color.FromArgb(44, 62, 80);
            btnCasilleros.Location = new Point(22, 484);
            btnCasilleros.Name = "btnCasilleros";
            btnCasilleros.Size = new Size(370, 42);
            btnCasilleros.TabIndex = 15;
            btnCasilleros.Text = "Abrir registro de casilleros";
            btnCasilleros.UseVisualStyleBackColor = false;
            btnCasilleros.Click += btnCasilleros_Click;
            // 
            // panelListado
            // 
            panelListado.BackColor = Color.White;
            panelListado.Controls.Add(lblCantidad);
            panelListado.Controls.Add(dgvClientes);
            panelListado.Location = new Point(468, 144);
            panelListado.Name = "panelListado";
            panelListado.Size = new Size(692, 520);
            panelListado.TabIndex = 2;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.Location = new Point(18, 18);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(147, 19);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Clientes registrados:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(18, 52);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(656, 450);
            dgvClientes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 233, 238);
            ClientSize = new Size(1184, 701);
            Controls.Add(panelListado);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 740);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AeroCasillero Proyecto";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelListado.ResumeLayout(false);
            panelListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelForm;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCasillero;
        private TextBox txtCasillero;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnPaquetes;
        private Button btnCasilleros;
        private Panel panelListado;
        private Label lblCantidad;
        private DataGridView dgvClientes;
    }
}
