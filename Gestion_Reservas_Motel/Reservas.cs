using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Reservas_Motel
{
    public partial class Reservas : Form
    {
        private LogicaReserva logicaReserva;
        private LogicaHabitacion logicaHabitacion;
        private LogicaCliente logicaCliente;
        public Reservas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicaReserva = new LogicaReserva();
            logicaHabitacion = new LogicaHabitacion();
            logicaCliente = new LogicaCliente();
            CargarHabitaciones();
            CargarClientes();   
            CargarReservas();

        }

        private void CargarReservas()
        {
            List<ReservasDTO> reservasDTOs = new List<ReservasDTO>(); 
            List<Reserva> reservas = logicaReserva.ObtenerReservas();
            foreach (var reserva in reservas)
            {
                ReservasDTO reservasDTO = new ReservasDTO();
                reservasDTO.Id = reserva.Id;
                reservasDTO.Habitacion = logicaHabitacion.ObtenerPorId(reserva.Habitacion);
                reservasDTO.Cliente = logicaCliente.ObtenerPorId(reserva.Cliente);
                reservasDTO.Fecha_Reserva = reserva.Fecha_Reserva;
                reservasDTO.Duracion = reserva.Duracion;
                reservasDTO.Costo = reserva.Costo;
                reservasDTO.Total = reserva.Costo*reserva.Duracion;
                reservasDTOs.Add(reservasDTO);
            }
            dgvReservas.DataSource = reservasDTOs;
            dgvReservas.Columns[0].HeaderText = "N°";
            dgvReservas.Columns[3].HeaderText = "Fecha Inicio";



        }

        private void CargarHabitaciones()
        {
            List<Habitacion> listHabitacion = logicaHabitacion.ObtenerHabitaciones();
            List<string> list = new List<string>();
            foreach (var habitacion in listHabitacion)
            {
                list.Add(habitacion.Nombre);

            }
            cbHabitacion.Items.AddRange(list.ToArray());

        }

        private void CargarClientes() 
        {
            List<Cliente> listCliente = logicaCliente.ObtenerClientes();
            List<string> list = new List<string>();
            foreach (var cliente in listCliente)
            {
                list.Add(cliente.Cedula);

            }
            cbCliente.Items.AddRange(list.ToArray());
        }
        private void lblHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones(); 
            habitaciones.Show();    
            this.Hide();
        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();   
            categorias.Show();  
            this.Hide();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();    
            this.Hide();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(); 
            clientes.Show();    
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NotreDame notreDame = new NotreDame();
            notreDame.Show();
            this.Hide();    
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
           string nombreHabitacion = cbHabitacion.SelectedItem.ToString();
           string cedulaCliente = cbCliente.SelectedItem.ToString();

            Habitacion habitacion = logicaHabitacion.ObtenerPorNombre(nombreHabitacion);
            Cliente cliente = logicaCliente.ObtenerPorCedula(cedulaCliente);

            Reserva reserva = new Reserva
            {
                Habitacion = habitacion.Id,
                Cliente = cliente.Id,
                Fecha_Reserva = dtpReservas.Value,
                Duracion = int.Parse(txtDuracion.Text),
                Costo = double.Parse(txtCosto.Text),
            };

            logicaReserva.AgregarReservas(reserva);
            CargarReservas();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvReservas.SelectedRows[0].Index;
                int IdReserva = (int)dgvReservas.Rows[selectedRowIndex].Cells["Id"].Value;

                logicaReserva.EliminarReservas(IdReserva);
                //logicaHabitacion.EliminarHabitaciones(IdHabitacion);
                CargarReservas();
                
            }
            else
            {
                MessageBox.Show("Seleccione una Habitacion para eliminar. ");
            }
        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {
            List<Reserva> reservas = logicaReserva.ObtenerReservas();
            Informacion informacion = new Informacion(reservas);
            informacion.Show();
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Red;
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor= Color.White;
        }
    }
}
