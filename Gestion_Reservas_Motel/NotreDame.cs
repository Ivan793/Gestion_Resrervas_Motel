using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Reservas_Motel
{
    public partial class NotreDame : Form
    {
        public NotreDame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnlblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Habitaciones habitaciones = new Habitaciones();
            habitaciones.Show();
            this.Hide();
        }

        private void NotreDame_Load(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
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

        private void lblHabitaciones_MouseEnter(object sender, EventArgs e)
        {
            lblHabitaciones.ForeColor = Color.White;
        }

        private void lblHabitaciones_MouseLeave(object sender, EventArgs e)
        {
            lblHabitaciones.ForeColor = Color.Black;
        }

        private void lblCategorias_MouseEnter(object sender, EventArgs e)
        {
            lblCategorias.ForeColor = Color.White;
        }

        private void lblCategorias_MouseLeave(object sender, EventArgs e)
        {
            lblCategorias.ForeColor = Color.Black;
        }

        private void lblUsuarios_MouseEnter(object sender, EventArgs e)
        {
            lblUsuarios.ForeColor = Color.White;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            lblUsuarios.ForeColor = Color.Black;
        }

        private void lblClientes_MouseEnter(object sender, EventArgs e)
        {
            lblClientes.ForeColor = Color.White;
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e)
        {
            lblClientes.ForeColor = Color.Black;
        }

        private void lblReservas_MouseEnter(object sender, EventArgs e)
        {
            lblReservas.ForeColor = Color.White;
        }

        private void lblReservas_MouseLeave(object sender, EventArgs e)
        {
            lblReservas.ForeColor = Color.Black;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirUbicacionEnGoogleMaps();
        }

        private void AbrirUbicacionEnGoogleMaps()
        {
            // URL de Google Maps con la ubicación del motel
            string url = "https://maps.app.goo.gl/G6NQTndkgo6rrdSL6"; // Cambia esta URL a la ubicación deseada

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                // Si ocurre una excepción, intentar abrir con el comando "start" de cmd
                try
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el navegador: " + ex.Message);
                }
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            lblNombreUbicacion.ForeColor = Color.Red;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            lblNombreUbicacion.ForeColor = Color.Black;
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

        private void lblReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas(); 
            reservas.Show();    
            this.Hide();    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.Red;
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.White;
        }
    }
    
}
