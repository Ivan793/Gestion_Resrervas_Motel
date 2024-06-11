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
    public partial class Usuarios : Form
    {

        private LogicaUsuario logicaUsuario;
        public Usuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicaUsuario = new LogicaUsuario();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            List<Usuario> usuarios = logicaUsuario.ObtenerUsuarios();
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Columns[0].HeaderText = "N°";

        }


        private void label12_Click(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(); 
            clientes.Show();
            this.Hide();    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado != -1)
            {
                if (txtNombre.Text == "" || txtTelefono.Text=="" || cbGenero.SelectedIndex == -1 || txtContraseña.Text == "")
                {
                    MessageBox.Show("Falta información");
                }
                else
                {
                    
                    Usuario usuarioActualizado = new Usuario
                    {
                        Id = idUsuarioSeleccionado,
                        Nombre = txtNombre.Text,
                        Telefono = txtTelefono.Text,
                        Genero = cbGenero.Text,
                        Contraseña = txtContraseña.Text,
                    };

                    logicaUsuario.ActualizarUsuarios(usuarioActualizado);
                    CargarUsuarios();
                    txtNombre.Text = " ";
                    txtTelefono.Text = "";
                    cbGenero.SelectedIndex = 0;
                    txtContraseña.Text = " ";
                    idUsuarioSeleccionado = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario para editar.");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtTelefono.Text=="" || cbGenero.SelectedIndex==-1 || txtContraseña.Text=="" )
            {
                MessageBox.Show("Falta informacion");
            }
            else {
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Genero = cbGenero.Text,
                    Contraseña = txtContraseña.Text,
                };

                logicaUsuario.AgregarUsuarios(nuevoUsuario);
                CargarUsuarios();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                cbGenero.SelectedIndex = 0;
                txtContraseña.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvUsuarios.SelectedRows[0].Index;
                int IdUsuario = (int)dgvUsuarios.Rows[selectedRowIndex].Cells["Id"].Value;

                logicaUsuario.EliminarUsuarios(IdUsuario);
                CargarUsuarios();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                cbGenero.SelectedIndex = 0;
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private int idUsuarioSeleccionado = -1;
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvUsuarios.SelectedRows[0].Index;
                idUsuarioSeleccionado = (int)dgvUsuarios.Rows[selectedRowIndex].Cells["Id"].Value;

                // Cargar los datos de la habitación seleccionada en los controles
                txtNombre.Text = dgvUsuarios.Rows[selectedRowIndex].Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString();
                cbGenero.SelectedItem = dgvUsuarios.Rows[selectedRowIndex].Cells["Genero"].Value.ToString();
                txtContraseña.Text = dgvUsuarios.Rows[selectedRowIndex].Cells["Contraseña"].Value.ToString();
            }
        }
    }
}
