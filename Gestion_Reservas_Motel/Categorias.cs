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
    public partial class Categorias : Form
    {
        private LogicaCategoria logicaCategoria;
        public Categorias()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicaCategoria = new LogicaCategoria();
            CargarCategorias();
        }

        private void CargarCategorias()
        {

            List<Categoria> categorias = logicaCategoria.ObtenerCategorias();
            dgvCategorias.DataSource = categorias;
            dgvCategorias.Columns[0].HeaderText = "N°";


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Falta informacion");
            }
            else {
                Categoria nuevaCategoria = new Categoria
                {
                    Nombre = txtNombre.Text,
                    

                };


                logicaCategoria.AgregarCategoria(nuevaCategoria);
                CargarCategorias();
                txtNombre.Text = " ";
               
                
            }
        }



        private void lblHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones hb = new Habitaciones();
            hb.Show();
            this.Hide();  
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Show();
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

            if (idCategoriaSeleccionada != -1)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Falta información");
                }
                else
                {
                    
                    
                    Categoria categoriaActualizada = new Categoria
                    {
                        Id = idCategoriaSeleccionada,
                        Nombre = txtNombre.Text,
                        
                    };

                    logicaCategoria.ActualizarCategoria(categoriaActualizada);
                    CargarCategorias();
                    txtNombre.Text = " ";
                   
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Categoria para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCategorias.SelectedRows[0].Index;
                int IdCategoria = (int)dgvCategorias.Rows[selectedRowIndex].Cells["Id"].Value;

                logicaCategoria.EliminarCategoria(IdCategoria);
                CargarCategorias();
                txtNombre.Text = " ";
                
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
            }
        }

        private void dataGridViewCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                
            }
        }

      
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

       

        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NotreDame notreDame = new NotreDame();
            notreDame.Show();   
            this.Hide();    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Red;
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor= Color.White;
        }

        private int idCategoriaSeleccionada = -1;
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCategorias.SelectedRows[0].Index;
                idCategoriaSeleccionada = (int)dgvCategorias.Rows[selectedRowIndex].Cells["Id"].Value;

                // Cargar los datos de la habitación seleccionada en los controles
                txtNombre.Text = dgvCategorias.Rows[selectedRowIndex].Cells["Nombre"].Value.ToString();
                
            }
        }
    }
}
