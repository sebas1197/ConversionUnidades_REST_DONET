using Cliente_ConversionUnidades.ec.edu.monster.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_ConversionUnidades
{
    public partial class Form1 : Form
    {
        private ConversionUnidadesControl conversionUnidadesControl = new ConversionUnidadesControl();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pulgadasAcentimetros_Click(object sender, EventArgs e)
        {
            double pulgadas = Convert.ToDouble(txt_pulgadasAcentimetros.Text);
            MessageBox.Show("Resultado" + "\nCentimetros convertidos: " + this.conversionUnidadesControl.pulgadasAcentimetros(pulgadas) / 100000000000000000);
        }

        private void btn_centimetrosApulgadas_Click(object sender, EventArgs e)
        {
            double centimetros = Convert.ToDouble(txt_centimetrosApulgadas.Text); 
            MessageBox.Show("Resultado" + "\nPulgadas convertidas: " +  this.conversionUnidadesControl.centimetrosApulgadas(centimetros) / 100000000000000000);
        }
    }
}
