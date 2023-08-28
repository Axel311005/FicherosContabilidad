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

        public int num = 1;
        public int num2 = 0;

        ClaseAltoBajo objAb = new();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            num2++;
            if (num2 == 5)
            {
                MessageBox.Show("No puede agregar mas de 10 datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAgregar.Enabled = false;
            }
            if (Validar() == "")
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




            ListViewItem fila = new ListViewItem(num++.ToString());
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

        public double EncontrarCostoAlto()
        {
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0;

            if (lvTabla.Items[0].SubItems[2].Text.Trim().Length == 0)
            {
                v1 = 0;
            }
            else
            {
                v1 = double.Parse(lvTabla.Items[0].SubItems[2].Text);
            }

            if (lvTabla.Items[1].SubItems[2].Text.Trim().Length == 0)
            {
                v2 = 0;
            }
            else
            {
                v2 = double.Parse(lvTabla.Items[1].SubItems[2].Text);
            }

            if (lvTabla.Items[2].SubItems[2].Text.Trim().Length == 0)
            {
                v3 = 0;
            }
            else
            {
                v3 = double.Parse(lvTabla.Items[2].SubItems[2].Text);
            }

            if (lvTabla.Items[3].SubItems[2].Text.Trim().Length == 0)
            {
                v4 = 0;
            }
            else
            {
                v4 = double.Parse(lvTabla.Items[3].SubItems[2].Text);
            }

            if (lvTabla.Items[4].SubItems[2].Text.Trim().Length == 0)
            {
                v5 = 0;
            }
            else
            {
                v5 = double.Parse(lvTabla.Items[4].SubItems[2].Text);
            }

            if (lvTabla.Items[5].SubItems[2].Text.Trim().Length == 0)
            {
                v6 = 0;
            }
            else
            {
                v6 = double.Parse(lvTabla.Items[5].SubItems[2].Text);
            }

            if (lvTabla.Items[6].SubItems[2].Text.Trim().Length == 0)
            {
                v7 = 0;
            }
            else
            {
                v7 = double.Parse(lvTabla.Items[6].SubItems[2].Text);
            }

            if (lvTabla.Items[7].SubItems[2].Text.Trim().Length == 0)
            {
                v8 = 0;
            }
            else
            {
                v8 = double.Parse(lvTabla.Items[7].SubItems[2].Text);
            }

            if (lvTabla.Items[8].SubItems[2].Text.Trim().Length == 0)
            {
                v9 = 0;
            }
            else
            {
                v9 = double.Parse(lvTabla.Items[8].SubItems[2].Text);
            }

            if (lvTabla.Items[9].SubItems[2].Text.Trim().Length == 0)
            {
                v10 = 0;
            }
            else
            {
                v10 = double.Parse(lvTabla.Items[9].SubItems[2].Text);
            }




            if (v1 > v2 && v1 > v3 && v1 > v4 && v1 > v5 && v1 > v6 && v1 > v7 && v1 > v8 && v1 > v9 && v1 > v10)
            {
                return v1;
            }
            else if (v2 > v1 && v2 > v3 && v2 > v4 && v2 > v5 && v2 > v6 && v2 > v7 && v2 > v8 && v2 > v9 && v2 > v10)
            {
                return v2;
            }
            else if (v3 > v1 && v3 > v2 && v3 > v4 && v3 > v5 && v3 > v6 && v3 > v7 && v3 > v8 && v3 > v9 && v3 > v10)
            {
                return v3;
            }
            else if (v4 > v1 && v4 > v2 && v4 > v3 && v4 > v5 && v4 > v6 && v4 > v7 && v4 > v8 && v4 > v9 && v4 > v10)
            {
                return v4;
            }
            else if (v5 > v1 && v5 > v2 && v5 > v3 && v5 > v4 && v5 > v6 && v5 > v7 && v5 > v8 && v5 > v9 && v5 > v10)
            {
                return v5;
            }
            else if (v6 > v1 && v6 > v2 && v6 > v3 && v6 > v4 && v6 > v5 && v6 > v7 && v6 > v8 && v6 > v9 && v6 > v10)
            {
                return v6;
            }
            else if (v7 > v1 && v7 > v2 && v7 > v3 && v7 > v4 && v7 > v5 && v7 > v6 && v7 > v8 && v7 > v9 && v7 > v10)
            {
                return v7;
            }
            else if (v8 > v1 && v8 > v2 && v8 > v3 && v8 > v4 && v8 > v5 && v8 > v6 && v8 > v7 && v8 > v9 && v8 > v10)
            {
                return v8;
            }
            else if (v9 > v2 && v9 > v3 && v9 > v4 && v9 > v5 && v9 > v6 && v9 > v7 && v9 > v8 && v9 > v1 && v9 > v10)
            {
                return v9;
            }
            else if (v10 > v2 && v10 > v3 && v10 > v4 && v10 > v5 && v10 > v6 && v10 > v7 && v10 > v8 && v10 > v9 && v10 > v1)
            {
                return v10;
            }


            return 0;

        }

        public double EncontrarCostoBajo()
        {
            double vv1 = 0, vv2 = 0, vv3 = 0, vv4 = 0, vv5 = 0, vv6 = 0, vv7 = 0, vv8 = 0, vv9 = 0, vv10 = 0;

            if (lvTabla.Items[0].SubItems[2].Text.Trim().Length == 0)
            {
                vv1 = 0;
            }
            else
            {
                vv1 = double.Parse(lvTabla.Items[0].SubItems[2].Text);
            }

            if (lvTabla.Items[1].SubItems[2].Text.Trim().Length == 0)
            {
                vv2 = 0;
            }
            else
            {
                vv2 = double.Parse(lvTabla.Items[1].SubItems[2].Text);
            }

            if (lvTabla.Items[2].SubItems[2].Text.Trim().Length == 0)
            {
                vv3 = 0;
            }
            else
            {
                vv3 = double.Parse(lvTabla.Items[2].SubItems[2].Text);
            }

            if (lvTabla.Items[3].SubItems[2].Text.Trim().Length == 0)
            {
                vv4 = 0;
            }
            else
            {
                vv4 = double.Parse(lvTabla.Items[3].SubItems[2].Text);
            }

            if (lvTabla.Items[4].SubItems[2].Text.Trim().Length == 0)
            {
                vv5 = 0;
            }
            else
            {
                vv5 = double.Parse(lvTabla.Items[4].SubItems[2].Text);
            }

            if (lvTabla.Items[5].SubItems[2].Text.Trim().Length == 0)
            {
                vv6 = 0;
            }
            else
            {
                vv6 = double.Parse(lvTabla.Items[5].SubItems[2].Text);
            }

            if (lvTabla.Items[6].SubItems[2].Text.Trim().Length == 0)
            {
                vv7 = 0;
            }
            else
            {
                vv7 = double.Parse(lvTabla.Items[6].SubItems[2].Text);
            }

            if (lvTabla.Items[7].SubItems[2].Text.Trim().Length == 0)
            {
                vv8 = 0;
            }
            else
            {
                vv8 = double.Parse(lvTabla.Items[7].SubItems[2].Text);
            }

            if (lvTabla.Items[8].SubItems[2].Text.Trim().Length == 0)
            {
                vv9 = 0;
            }
            else
            {
                vv9 = double.Parse(lvTabla.Items[8].SubItems[2].Text);
            }

            if (lvTabla.Items[9].SubItems[2].Text.Trim().Length == 0)
            {
                vv10 = 0;
            }
            else
            {
                vv10 = double.Parse(lvTabla.Items[9].SubItems[2].Text);
            }


            if (vv1 < vv2 && vv1 < vv3 && vv1 < vv4 && vv1 < vv5 && vv1 < vv6 && vv1 < vv7 && vv1 < vv8 && vv1 < vv9 && vv1 < vv10)
            {
                return vv1;
            }
            else if (vv2 < vv1 && vv2 < vv3 && vv2 < vv4 && vv2 < vv5 && vv2 < vv6 && vv2 < vv7 && vv2 < vv8 && vv2 < vv9 && vv2 < vv10)
            {
                return vv2;
            }
            else if (vv3 < vv1 && vv3 < vv2 && vv3 < vv4 && vv3 < vv5 && vv3 < vv6 && vv3 < vv7 && vv3 < vv8 && vv3 < vv9 && vv3 < vv10)
            {
                return vv3;
            }
            else if (vv4 < vv1 && vv4 < vv2 && vv4 < vv3 && vv4 < vv5 && vv4 < vv6 && vv4 < vv7 && vv4 < vv8 && vv4 < vv9 && vv4 < vv10)
            {
                return vv4;
            }
            else if (vv5 < vv1 && vv5 < vv2 && vv5 < vv3 && vv5 < vv4 && vv5 < vv6 && vv5 < vv7 && vv5 < vv8 && vv5 < vv9 && vv5 < vv10)
            {
                return vv5;
            }
            else if (vv6 < vv1 && vv6 < vv2 && vv6 < vv3 && vv6 < vv4 && vv6 < vv5 && vv6 < vv7 && vv6 < vv8 && vv6 < vv9 && vv6 < vv10)
            {
                return vv6;
            }
            else if (vv7 < vv1 && vv7 < vv2 && vv7 < vv3 && vv7 < vv4 && vv7 < vv5 && vv7 < vv6 && vv7 < vv8 && vv7 < vv9 && vv7 < vv10)
            {
                return vv7;
            }
            else if (vv8 < vv1 && vv8 < vv2 && vv8 < vv3 && vv8 < vv4 && vv8 < vv5 && vv8 < vv6 && vv8 < vv7 && vv8 < vv9 && vv8 < vv10)
            {
                return vv8;
            }
            else if (vv9 < vv2 && vv9 < vv3 && vv9 < vv4 && vv9 < vv5 && vv9 < vv6 && vv9 < vv7 && vv9 < vv8 && vv9 < vv1 && vv9 < vv10)
            {
                return vv9;
            }
            else if (vv10 < vv2 && vv10 < vv3 && vv10 < vv4 && vv10 < vv5 && vv10 < vv6 && vv10 < vv7 && vv10 < vv8 && vv10 < vv9 && vv10 < vv1)
            {
                return vv10;
            }


            return 0;
        }

        public double CalcularUnidadAlta()
        {
            double bv1 = 0, bv2 = 0, bv3 = 0, bv4 = 0, bv5 = 0, bv6 = 0, bv7 = 0, bv8 = 0, bv9 = 0, bv10 = 0;

            if (lvTabla.Items[0].SubItems[1].Text.Trim().Length == 0)
            {
                bv1 = 0;
            }
            else
            {
                bv1 = double.Parse(lvTabla.Items[0].SubItems[1].Text);
            }

            if (lvTabla.Items[1].SubItems[1].Text.Trim().Length == 0)
            {
                bv2 = 0;
            }
            else
            {
                bv2 = double.Parse(lvTabla.Items[1].SubItems[1].Text);
            }

            if (lvTabla.Items[2].SubItems[1].Text.Trim().Length == 0)
            {
                bv3 = 0;
            }
            else
            {
                bv3 = double.Parse(lvTabla.Items[2].SubItems[1].Text);
            }

            if (lvTabla.Items[3].SubItems[1].Text.Trim().Length == 0)
            {
                bv4 = 0;
            }
            else
            {
                bv4 = double.Parse(lvTabla.Items[3].SubItems[1].Text);
            }

            if (lvTabla.Items[4].SubItems[1].Text.Trim().Length == 0)
            {
                bv5 = 0;
            }
            else
            {
                bv5 = double.Parse(lvTabla.Items[4].SubItems[1].Text);
            }

            if (lvTabla.Items[5].SubItems[1].Text.Trim().Length == 0)
            {
                bv6 = 0;
            }
            else
            {
                bv6 = double.Parse(lvTabla.Items[5].SubItems[1].Text);
            }

            if (lvTabla.Items[6].SubItems[1].Text.Trim().Length == 0)
            {
                bv7 = 0;
            }
            else
            {
                bv7 = double.Parse(lvTabla.Items[6].SubItems[1].Text);
            }

            if (lvTabla.Items[7].SubItems[1].Text.Trim().Length == 0)
            {
                bv8 = 0;
            }
            else
            {
                bv8 = double.Parse(lvTabla.Items[7].SubItems[1].Text);
            }

            if (lvTabla.Items[8].SubItems[1].Text.Trim().Length == 0)
            {
                bv9 = 0;
            }
            else
            {
                bv9 = double.Parse(lvTabla.Items[8].SubItems[1].Text);
            }

            if (lvTabla.Items[9].SubItems[1].Text.Trim().Length == 0)
            {
                bv10 = 0;
            }
            else
            {
                bv10 = double.Parse(lvTabla.Items[9].SubItems[1].Text);
            }


            if (bv1 > bv2 && bv1 > bv3 && bv1 > bv4 && bv1 > bv5 && bv1 > bv6 && bv1 > bv7 && bv1 > bv8 && bv1 > bv9 && bv1 > bv10)
            {
                return bv1;
            }
            else if (bv2 > bv1 && bv2 > bv3 && bv2 > bv4 && bv2 > bv5 && bv2 > bv6 && bv2 > bv7 && bv2 > bv8 && bv2 > bv9 && bv2 > bv10)
            {
                return bv2;
            }
            else if (bv3 > bv1 && bv3 > bv2 && bv3 > bv4 && bv3 > bv5 && bv3 > bv6 && bv3 > bv7 && bv3 > bv8 && bv3 > bv9 && bv3 > bv10)
            {
                return bv3;
            }
            else if (bv4 > bv1 && bv4 > bv2 && bv4 > bv3 && bv4 > bv5 && bv4 > bv6 && bv4 > bv7 && bv4 > bv8 && bv4 > bv9 && bv4 > bv10)
            {
                return bv4;
            }
            else if (bv5 > bv1 && bv5 > bv2 && bv5 > bv3 && bv5 > bv4 && bv5 > bv6 && bv5 > bv7 && bv5 > bv8 && bv5 > bv9 && bv5 > bv10)
            {
                return bv5;
            }
            else if (bv6 > bv1 && bv6 > bv2 && bv6 > bv3 && bv6 > bv4 && bv6 > bv5 && bv6 > bv7 && bv6 > bv8 && bv6 > bv9 && bv6 > bv10)
            {
                return bv6;
            }
            else if (bv7 > bv1 && bv7 > bv2 && bv7 > bv3 && bv7 > bv4 && bv7 > bv5 && bv7 > bv6 && bv7 > bv8 && bv7 > bv9 && bv7 > bv10)
            {
                return bv7;
            }
            else if (bv8 > bv1 && bv8 > bv2 && bv8 > bv3 && bv8 > bv4 && bv8 > bv5 && bv8 > bv6 && bv8 > bv7 && bv8 > bv9 && bv8 > bv10)
            {
                return bv8;
            }
            else if (bv9 > bv2 && bv9 > bv3 && bv9 > bv4 && bv9 > bv5 && bv9 > bv6 && bv9 > bv7 && bv9 > bv8 && bv9 > bv1 && bv9 > bv10)
            {
                return bv9;
            }
            else if (bv10 > bv2 && bv10 > bv3 && bv10 > bv4 && bv10 > bv5 && bv10 > bv6 && bv10 > bv7 && bv10 > bv8 && bv10 > bv9 && bv10 > bv1)
            {
                return bv10;
            }


            return 0;
        }

        public double CalcularUnidadBaja()
        {
            double vv1 = 0, vv2 = 0, vv3 = 0, vv4 = 0, vv5 = 0, vv6 = 0, vv7 = 0, vv8 = 0, vv9 = 0, vv10 = 0;

            if (lvTabla.Items[0].SubItems[1].Text.Trim().Length == 0)
            {
                vv1 = 0;
            }
            else
            {
                vv1 = double.Parse(lvTabla.Items[0].SubItems[1].Text);
            }

            if (lvTabla.Items[1].SubItems[1].Text.Trim().Length == 0)
            {
                vv2 = 0;
            }
            else
            {
                vv2 = double.Parse(lvTabla.Items[1].SubItems[1].Text);
            }

            if (lvTabla.Items[2].SubItems[1].Text.Trim().Length == 0)
            {
                vv3 = 0;
            }
            else
            {
                vv3 = double.Parse(lvTabla.Items[2].SubItems[1].Text);
            }

            if (lvTabla.Items[3].SubItems[1].Text.Trim().Length == 0)
            {
                vv4 = 0;
            }
            else
            {
                vv4 = double.Parse(lvTabla.Items[3].SubItems[1].Text);
            }

            if (lvTabla.Items[4].SubItems[1].Text.Trim().Length == 0)
            {
                vv5 = 0;
            }
            else
            {
                vv5 = double.Parse(lvTabla.Items[4].SubItems[1].Text);
            }

            if (lvTabla.Items[5].SubItems[1].Text.Trim().Length == 0)
            {
                vv6 = 0;
            }
            else
            {
                vv6 = double.Parse(lvTabla.Items[5].SubItems[1].Text);
            }

            if (lvTabla.Items[6].SubItems[1].Text.Trim().Length == 0)
            {
                vv7 = 0;
            }
            else
            {
                vv7 = double.Parse(lvTabla.Items[6].SubItems[1].Text);
            }

            if (lvTabla.Items[7].SubItems[1].Text.Trim().Length == 0)
            {
                vv8 = 0;
            }
            else
            {
                vv8 = double.Parse(lvTabla.Items[7].SubItems[1].Text);
            }

            if (lvTabla.Items[8].SubItems[1].Text.Trim().Length == 0)
            {
                vv9 = 0;
            }
            else
            {
                vv9 = double.Parse(lvTabla.Items[8].SubItems[1].Text);
            }

            if (lvTabla.Items[9].SubItems[1].Text.Trim().Length == 0)
            {
                vv10 = 0;
            }
            else
            {
                vv10 = double.Parse(lvTabla.Items[9].SubItems[1].Text);
            }




            if (vv1 < vv2 && vv1 < vv3 && vv1 < vv4 && vv1 < vv5 && vv1 < vv6 && vv1 < vv7 && vv1 < vv8 && vv1 < vv9 && vv1 < vv10)
            {
                return vv1;
            }
            else if (vv2 < vv1 && vv2 < vv3 && vv2 < vv4 && vv2 < vv5 && vv2 < vv6 && vv2 < vv7 && vv2 < vv8 && vv2 < vv9 && vv2 < vv10)
            {
                return vv2;
            }
            else if (vv3 < vv1 && vv3 < vv2 && vv3 < vv4 && vv3 < vv5 && vv3 < vv6 && vv3 < vv7 && vv3 < vv8 && vv3 < vv9 && vv3 < vv10)
            {
                return vv3;
            }
            else if (vv4 < vv1 && vv4 < vv2 && vv4 < vv3 && vv4 < vv5 && vv4 < vv6 && vv4 < vv7 && vv4 < vv8 && vv4 < vv9 && vv4 < vv10)
            {
                return vv4;
            }
            else if (vv5 < vv1 && vv5 < vv2 && vv5 < vv3 && vv5 < vv4 && vv5 < vv6 && vv5 < vv7 && vv5 < vv8 && vv5 < vv9 && vv5 < vv10)
            {
                return vv5;
            }
            else if (vv6 < vv1 && vv6 < vv2 && vv6 < vv3 && vv6 < vv4 && vv6 < vv5 && vv6 < vv7 && vv6 < vv8 && vv6 < vv9 && vv6 < vv10)
            {
                return vv6;
            }
            else if (vv7 < vv1 && vv7 < vv2 && vv7 < vv3 && vv7 < vv4 && vv7 < vv5 && vv7 < vv6 && vv7 < vv8 && vv7 < vv9 && vv7 < vv10)
            {
                return vv7;
            }
            else if (vv8 < vv1 && vv8 < vv2 && vv8 < vv3 && vv8 < vv4 && vv8 < vv5 && vv8 < vv6 && vv8 < vv7 && vv8 < vv9 && vv8 < vv10)
            {
                return vv8;
            }
            else if (vv9 < vv2 && vv9 < vv3 && vv9 < vv4 && vv9 < vv5 && vv9 < vv6 && vv9 < vv7 && vv9 < vv8 && vv9 < vv1 && vv9 < vv10)
            {
                return vv9;
            }
            else if (vv10 < vv2 && vv10 < vv3 && vv10 < vv4 && vv10 < vv5 && vv10 < vv6 && vv10 < vv7 && vv10 < vv8 && vv10 < vv9 && vv10 < vv1)
            {
                return vv10;
            }


            return 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objAb.costoAlto = EncontrarCostoAlto();
            objAb.costoBajo= EncontrarCostoBajo();
            objAb.unidadesBaja=CalcularUnidadBaja();
            objAb.unidadesAlta=CalcularUnidadAlta();

            txtCostosFijos.Text = objAb.costosFijoss().ToString();
            txtCostosVariables.Text= objAb.costosVariables().ToString();
            txtCostosTotales.Text = objAb.Total().ToString();

        }
    }
}
