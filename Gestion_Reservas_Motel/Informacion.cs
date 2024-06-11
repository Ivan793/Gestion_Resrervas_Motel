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
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion_Reservas_Motel
{
    public partial class Informacion : Form
    {
        public Informacion(Reserva reserva)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeChart();
        }

        public Informacion(List<Reserva> reservas)
        {
            this.reservas = reservas;
            chart = new Chart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(chart);

            // Inicializar el Chart
            InitializeChart();

            // Cargar los datos al iniciar el formulario
            LoadChartData(reservas);
        }
        private void InitializeChart()
        {
            chart.ChartAreas.Add(new ChartArea("MainArea"));
            chart.Series.Add(new Series("Total Reservas")
            {
                ChartType = SeriesChartType.Column
            });
            chart.Titles.Add("Total de Reservas por Mes");
        }

        private void LoadChartData(List<Reserva> reservas)
        {
            // Procesar los datos para obtener el total por mes
            var totalPorMes = reservas
                .GroupBy(r => new { r.Fecha_Reserva.Year, r.Fecha_Reserva.Month })
                .Select(g => new
                {
                    Mes = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Total = g.Sum(r => r.Costo * r.Duracion)
                })
                .OrderBy(x => x.Mes)
                .ToList();

            // Limpiar los puntos del Chart
            chart.Series["Total Reservas"].Points.Clear();

            // Llenar el Chart con los datos procesados
            foreach (var item in totalPorMes)
            {
                chart.Series["Total Reservas"].Points.AddXY(item.Mes.ToString("MM/yyyy"), item.Total);
            }
        }

        private Chart chart;
        private List<Reserva> reservas;

       
        private void Informacion_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
