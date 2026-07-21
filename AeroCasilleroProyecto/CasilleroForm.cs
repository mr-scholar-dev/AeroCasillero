using AeroCasilleroProyecto.BLL;
using AeroCasilleroProyecto.DAL;
using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto
{
    public partial class CasilleroForm : Form
    {
        private readonly CasilleroService _casilleroService;

        public CasilleroForm()
        {
            InitializeComponent();

            _casilleroService = new CasilleroService(new SqlCasilleroRepository());
            ConfigurarGrid();
            CargarDatosIniciales();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvCasilleros.AutoGenerateColumns = false;
            dgvCasilleros.Columns.Clear();
            dgvCasilleros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "CasilleroId", Width = 60 });
            dgvCasilleros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Número", DataPropertyName = "NumeroCasillero", Width = 120 });
            dgvCasilleros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ubicación", DataPropertyName = "Ubicacion", Width = 180 });
            dgvCasilleros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tamaño", DataPropertyName = "Tamano", Width = 120 });
            dgvCasilleros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado", Width = 120 });
        }

        private void CargarDatosIniciales()
        {
            if (_casilleroService.GetAll().Any())
            {
                return;
            }

            _casilleroService.Create(new CasilleroDto
            {
                NumeroCasillero = "CAS-001",
                Ubicacion = "Miami, FL",
                Tamano = "Mediano",
                Estado = "Disponible"
            });

            _casilleroService.Create(new CasilleroDto
            {
                NumeroCasillero = "CAS-002",
                Ubicacion = "Orlando, FL",
                Tamano = "Pequeño",
                Estado = "Disponible"
            });
        }

        private void RefrescarGrid()
        {
            var items = _casilleroService.GetAll().ToList();
            dgvCasilleros.DataSource = items;
            lblCantidad.Text = $"Casilleros registrados: {items.Count}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var casillero = new CasilleroDto
                {
                    NumeroCasillero = txtNumero.Text.Trim(),
                    Ubicacion = txtUbicacion.Text.Trim(),
                    Tamano = cboTamano.Text.Trim(),
                    Estado = cboEstado.Text.Trim()
                };

                _casilleroService.Create(casillero);

                LimpiarCampos();
                RefrescarGrid();
                MessageBox.Show("Casillero registrado correctamente.", "AeroCasillero", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtUbicacion.Clear();
            cboTamano.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            txtNumero.Focus();
        }
    }
}
