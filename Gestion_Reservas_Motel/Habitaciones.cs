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
    public partial class Habitaciones : Form
    {
        private LogicaHabitacion logicaHabitacion;
        private LogicaCategoria logicaCategoria;

        public Habitaciones()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicaHabitacion = new LogicaHabitacion();
            logicaCategoria = new LogicaCategoria();
            CargarCategorias();
            CargarHabitaciones();
        }

        private void CargarHabitaciones()
        {
            List<HabitacionDTO> habitacionDTOs = new List<HabitacionDTO>();
            List<Habitacion> habitacions = logicaHabitacion.ObtenerHabitaciones();
            foreach (var habitacion in habitacions)
            {
                HabitacionDTO habitacionDTO = new HabitacionDTO();
                habitacionDTO.Id = habitacion.Id;
                habitacionDTO.Nombre = habitacion.Nombre;
                habitacionDTO.Estado = habitacion.Estado;
                habitacionDTO.Tipo = logicaCategoria.ObtenerPorId(habitacion.Tipo);
                habitacionDTOs.Add(habitacionDTO);
            }
            dgvHabitaciones.DataSource = habitacionDTOs;
            dgvHabitaciones.Columns[0].HeaderText = "N°";
        }

        private void CargarCategorias()
        {
            List<Categoria> listCategoria = logicaCategoria.ObtenerCategorias();
            List<string> list = new List<string>();
            foreach (var categoria in listCategoria)
            {
                list.Add(categoria.Nombre);

            }
            cbTipo.Items.AddRange(list.ToArray());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblHabitaciones_Click(object sender, EventArgs e)
        {

        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {
            Categorias ct = new Categorias();
            ct.Show();
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



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cbTipo.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Falta informacion");
            }
            else {
                string tipo = cbTipo.SelectedItem.ToString();
                Categoria categoria = logicaCategoria.ObtenerPorNombre(tipo);
                Habitacion nuevaHabitacion = new Habitacion
                {
                    Nombre = txtNombre.Text,
                    Tipo = categoria.Id,
                    Estado = cbEstado.Text,
                };

                logicaHabitacion.AgregarHabitaciones(nuevaHabitacion);
                CargarHabitaciones();
                txtNombre.Text = " ";
                cbTipo.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvHabitaciones.SelectedRows[0].Index;
                int IdHabitacion = (int)dgvHabitaciones.Rows[selectedRowIndex].Cells["Id"].Value;

                logicaHabitacion.EliminarHabitaciones(IdHabitacion);
                CargarHabitaciones();
                txtNombre.Text = " ";
                cbTipo.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una Habitacion para eliminar. ");
            }
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void lblReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();


        }

        private void pbNotredame_Click(object sender, EventArgs e)
        {
            NotreDame notreDame = new NotreDame();
            notreDame.Show();
            this.Hide();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idHabitacionSeleccionada != -1)
            {
                if (txtNombre.Text == "" || cbTipo.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta información");
                }
                else
                {
                    string tipo = cbTipo.SelectedItem.ToString();
                    Categoria categoria = logicaCategoria.ObtenerPorNombre(tipo);
                    Habitacion habitacionActualizada = new Habitacion
                    {
                        Id = idHabitacionSeleccionada,
                        Nombre = txtNombre.Text,
                        Tipo = categoria.Id,
                        Estado = cbEstado.Text,
                    };

                    logicaHabitacion.ActualizarHabitaciones(habitacionActualizada);
                    CargarHabitaciones();
                    txtNombre.Text = " ";
                    cbTipo.SelectedIndex = 0;
                    cbEstado.SelectedIndex = 0;
                    idHabitacionSeleccionada = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Habitación para editar.");
            }
        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Red;
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.White;
        }
        private int idHabitacionSeleccionada = -1;
        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvHabitaciones.SelectedRows[0].Index;
                idHabitacionSeleccionada = (int)dgvHabitaciones.Rows[selectedRowIndex].Cells["Id"].Value;

                // Cargar los datos de la habitación seleccionada en los controles
                txtNombre.Text = dgvHabitaciones.Rows[selectedRowIndex].Cells["Nombre"].Value.ToString();
                cbTipo.SelectedItem = dgvHabitaciones.Rows[selectedRowIndex].Cells["Tipo"].Value.ToString();
                cbEstado.SelectedItem = dgvHabitaciones.Rows[selectedRowIndex].Cells["Estado"].Value.ToString();
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   
    }
