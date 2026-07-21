using AeroCasilleroProyecto.BLL;
using AeroCasilleroProyecto.DAL;
using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto
{
    public partial class Form1 : Form
    {
        private readonly ClienteService _clienteService;

        public Form1()
        {
            InitializeComponent();

            _clienteService = new ClienteService(new SqlClienteRepository());
            ConfigurarGrid();
            CargarDatosIniciales();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ClienteId", Width = 60 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombres", DataPropertyName = "Nombres", Width = 140 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellidos", DataPropertyName = "Apellidos", Width = 140 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Documento", DataPropertyName = "CedulaPasaporte", Width = 110 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Correo", DataPropertyName = "Correo", Width = 180 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "Telefono", Width = 110 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Casillero", DataPropertyName = "NumeroCasillero", Width = 100 });
        }

        private void CargarDatosIniciales()
        {
            if (_clienteService.GetAll().Any())
            {
                return;
            }

            _clienteService.Create(new ClienteDto
            {
                Nombres = "Juan",
                Apellidos = "Pérez",
                CedulaPasaporte = "P1234567",
                Correo = "juan.perez@mail.com",
                Telefono = "8888-1111",
                CasilleroId = 1,
                NumeroCasillero = "CAS-001"
            });

            _clienteService.Create(new ClienteDto
            {
                Nombres = "María",
                Apellidos = "López",
                CedulaPasaporte = "P7654321",
                Correo = "maria.lopez@mail.com",
                Telefono = "8888-2222",
                CasilleroId = 2,
                NumeroCasillero = "CAS-002"
            });
        }

        private void RefrescarGrid()
        {
            dgvClientes.DataSource = _clienteService.GetAll().ToList();
            lblCantidad.Text = $"Clientes registrados: {_clienteService.GetAll().Count()}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new ClienteDto
                {
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    CedulaPasaporte = txtDocumento.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    CasilleroId = int.TryParse(txtCasillero.Text.Trim(), out var casilleroId) ? casilleroId : 0,
                    NumeroCasillero = txtCasillero.Text.Trim()
                };

                _clienteService.Create(cliente);

                LimpiarCampos();
                RefrescarGrid();
                MessageBox.Show("Cliente registrado correctamente.", "AeroCasillero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            using var form = new PaqueteForm();
            form.ShowDialog(this);
        }

        private void btnCasilleros_Click(object sender, EventArgs e)
        {
            using var form = new CasilleroForm();
            form.ShowDialog(this);
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCasillero.Clear();
            txtNombres.Focus();
        }
    }
}
