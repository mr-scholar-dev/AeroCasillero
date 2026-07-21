using AeroCasilleroProyecto.BLL;
using AeroCasilleroProyecto.DAL;
using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto
{
    public partial class PaqueteForm : Form
    {
        private readonly PaqueteService _paqueteService;

        public PaqueteForm()
        {
            InitializeComponent();

            _paqueteService = new PaqueteService(new SqlPaqueteRepository());
            ConfigurarGrid();
            CargarDatosIniciales();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvPaquetes.AutoGenerateColumns = false;
            dgvPaquetes.Columns.Clear();
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "PaqueteId", Width = 60 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tracking", DataPropertyName = "Tracking", Width = 120 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Peso", DataPropertyName = "Peso", Width = 70 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Alto", DataPropertyName = "Alto", Width = 70 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ancho", DataPropertyName = "Ancho", Width = 70 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Largo", DataPropertyName = "Largo", Width = 70 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Transportista", DataPropertyName = "Transportista", Width = 120 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado", Width = 120 });
            dgvPaquetes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", DataPropertyName = "ClienteNombre", Width = 160 });
        }

        private void CargarDatosIniciales()
        {
            if (_paqueteService.GetAll().Any())
            {
                return;
            }

            _paqueteService.Create(new PaqueteDto
            {
                Tracking = "TRK-1001",
                Peso = 2.5m,
                Alto = 15,
                Ancho = 20,
                Largo = 25,
                Transportista = "UPS",
                FechaRecepcion = DateTime.Now,
                Estado = "RecibidoEnBodega",
                ClienteId = 1,
                ClienteNombre = "Juan Pérez"
            });

            _paqueteService.Create(new PaqueteDto
            {
                Tracking = "TRK-1002",
                Peso = 1.2m,
                Alto = 10,
                Ancho = 12,
                Largo = 18,
                Transportista = "FedEx",
                FechaRecepcion = DateTime.Now,
                Estado = "RecibidoEnBodega",
                ClienteId = 2,
                ClienteNombre = "María López"
            });
        }

        private void RefrescarGrid()
        {
            var items = _paqueteService.GetAll().ToList();
            dgvPaquetes.DataSource = items;
            lblCantidad.Text = $"Paquetes registrados: {items.Count}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var paquete = new PaqueteDto
                {
                    Tracking = txtTracking.Text.Trim(),
                    Peso = nudPeso.Value,
                    Alto = nudAlto.Value,
                    Ancho = nudAncho.Value,
                    Largo = nudLargo.Value,
                    Transportista = txtTransportista.Text.Trim(),
                    FechaRecepcion = dtpFechaRecepcion.Value,
                    Observaciones = txtObservaciones.Text.Trim(),
                    Estado = "RecibidoEnBodega",
                    ClienteId = 0,
                    ClienteNombre = txtCliente.Text.Trim()
                };

                _paqueteService.Create(paquete);

                LimpiarCampos();
                RefrescarGrid();
                MessageBox.Show("Paquete registrado correctamente.", "AeroCasillero", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtTracking.Clear();
            nudPeso.Value = 1;
            nudAlto.Value = 1;
            nudAncho.Value = 1;
            nudLargo.Value = 1;
            txtTransportista.Clear();
            txtObservaciones.Clear();
            txtCliente.Clear();
            dtpFechaRecepcion.Value = DateTime.Now;
            txtTracking.Focus();
        }
    }
}
