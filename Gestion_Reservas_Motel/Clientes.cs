using BLL;
using DALL;
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
    public partial class Clientes : Form
    {
        private LogicaCliente logicacliente;  

        public Clientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicacliente = new LogicaCliente();
            CargarClientes();
        }
        private void CargarClientes()
        {

            List<Cliente> clientes = logicacliente.ObtenerClientes();
            dgvClientes.DataSource = clientes;
            dgvClientes.Columns[0].HeaderText = "N°";


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text==""||txtTelefono.Text==""||cbGenero.SelectedIndex==-1 || txtCedula.Text=="")
            {
                MessageBox.Show("Falta informacion");
            }
            else {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Genero = cbGenero.Text,
                    Cedula = txtCedula.Text

                };
                logicacliente.AgregarClientes(nuevoCliente);
                CargarClientes();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                cbGenero.SelectedIndex = 0;
                txtCedula.Text = "";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            habitaciones.Show();    
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();     
            usuarios.Show();    
            this.Hide();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           /* if (idClienteSeleccionado != -1)
            {
                if (txtNombre.Text == "" || txtTelefono.Text == "" || cbGenero.SelectedIndex == -1 || txtCedula.Text == "")
                {
                    MessageBox.Show("Falta información");
                }
                else
                {
                    
                    Cliente ClienteActualizado = new Cliente
                    {
                        Id = idClienteSeleccionado,
                        Nombre = txtNombre.Text,
                        Telefono = txtTelefono.Text,
                        Genero = cbGenero.Text,
                        Cedula = txtCedula.Text,
                    };

                    logicacliente.ActualizarClientes(ClienteActualizado);
                    CargarClientes();
                    txtNombre.Text = " ";
                    txtTelefono.Text = " "; 
                    cbGenero.SelectedIndex = 0;
                    txtCedula.Text = " ";
                    idClienteSeleccionado = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente para editar.");
            }*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvClientes.SelectedRows[0].Index;
                int IdCliente = (int)dgvClientes.Rows[selectedRowIndex].Cells["Id"].Value;

                logicacliente.EliminarClientes(IdCliente);
                CargarClientes();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                cbGenero.SelectedIndex = 0;
                txtCedula.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lblReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NotreDame notre = new NotreDame();
            notre.Show();
            this.Hide();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private int idClienteSeleccionado = -1;
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvClientes.SelectedRows[0].Index;
                idClienteSeleccionado = (int)dgvClientes.Rows[selectedRowIndex].Cells["Id"].Value;

                // Cargar los datos de la habitación seleccionada en los controles
                txtNombre.Text = dgvClientes.Rows[selectedRowIndex].Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString();
                cbGenero.SelectedItem = dgvClientes.Rows[selectedRowIndex].Cells["Genero"].Value.ToString();
                txtCedula.Text = dgvClientes.Rows[selectedRowIndex].Cells["Cedula"].Value.ToString();
            }
        }
    }
}
