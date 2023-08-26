using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltoBajo
{
    public partial class AltoBajo : Form
    {
        public AltoBajo()
        {
            InitializeComponent();
        }

        ClaseAltoBajo objAb = new();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Validar()== "")
            {

                capturarDatos();
                ImprimirDetalle();
            }
            else
            {
                MessageBox.Show($"El error se encuentra en {Validar()}");
            }
        }

        private void ImprimirDetalle()
        {
            int num=0;
            num++;
            

            ListViewItem fila = new ListViewItem(num.ToString());
            fila.SubItems.Add(txtUnidades.Text);
            fila.SubItems.Add(txtCostosIngresados.Text);
            lvTabla.Items.Add(fila);
        }

        private void capturarDatos()
        {
            
        }

        private string Validar()
        {
            return "";
        }
    }
}
