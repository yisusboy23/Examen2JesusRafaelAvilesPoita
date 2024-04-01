using Examen2.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2.VISTA.ConsultaVista
{
    public partial class Consulta4Vista : Form
    {
        public Consulta4Vista()
        {
            InitializeComponent();
        }
        ConsultaBSS bss = new ConsultaBSS();
        private void Consulta4Vista_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bss.Consulta4BSS();
        }
    }
}
