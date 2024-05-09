using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiServicio.Service1Client oCliente = new MiServicio.Service1Client();
            // Llamar al método GetData y mostrar el resultado en labelResult1
            string res = oCliente.GetData(10);
            labelResult1.Text = res;

            // Crear una instancia de CompositeType, configurarla y llamar a GetDataUsingDataContract
            MiServicio.CompositeType oData = new MiServicio.CompositeType();
            oData.BoolValue = true;
            var res2 = oCliente.GetDataUsingDataContract(oData);

            // Mostrar el resultado en labelResult2
            labelResult2.Text = res2.StringValue;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
