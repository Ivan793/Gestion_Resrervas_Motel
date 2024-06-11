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
    public partial class Login : Form
    {
        private Button btnLogin;
        private LogicaUsuario logicaUsuario;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logicaUsuario = new LogicaUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
             if(txtUsuario.Text == "" || txtContraseña.Text == "")
             {
                 MessageBox.Show("Falta informacion");
             }
             else
             {
                 string nombre = txtUsuario.Text;
                 string contraseña = txtContraseña.Text;

                 bool esValido = logicaUsuario.ValidarUsuario(nombre, contraseña);

                 if (esValido)
                 {
                     //
                     // Redirigir al usuario a la siguiente ventana o funcionalidad
                     NotreDame notreDame = new NotreDame();
                      notreDame.Show();
                      this.Hide();    
                 }
                 else
                 {
                     MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                 }
             }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
