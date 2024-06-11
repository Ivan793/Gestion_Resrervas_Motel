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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int StarP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StarP += 1;
            MyProgress.Value = StarP;
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login obj = new Login();
                this.Hide();
                obj.Show();
            }

        }

        private void MyProgress_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
