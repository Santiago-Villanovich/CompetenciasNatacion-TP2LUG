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
using BE;
using BLL;


namespace UI
{
    public partial class formInforme : Form
    {
        public void LlenarLista()
        {

            listaNad = bllNad.ListarObjs();
        }

        public formInforme()
        {
            InitializeComponent();
            beNad = new BEnadador();
            bllNad = new BLLnadador();
            ChartLoad();
        }

        public List<BEnadador> listaNad = new List<BEnadador>();
        public BEnadador beNad;
        public BLLnadador bllNad;

        public void ChartLoad()
        {
            LlenarLista();

            Dictionary<int, int> Datos = new Dictionary<int, int>();
            foreach (BEnadador items in listaNad)
            {
                beNad = new BEnadador();
                beNad = items;
                Datos.Add(beNad.ID,beNad.edad );

            }

            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            
            Title titulo = new Title("Promedio de Edades");
            titulo.Font = new Font("Tahoma", 20, FontStyle.Bold);
            chart1.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chart1.ChartAreas.Add(area);

            Series serie = new Series("Edad");

            serie.ChartType = SeriesChartType.Pie;
            serie.Points.DataBindXY(Datos.Keys, Datos.Values);

            chart1.Series.Add(serie);

        }

        

        
        

        
    }
}
