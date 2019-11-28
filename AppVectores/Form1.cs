using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVectores
{
    public partial class Form1 : Form
    {
        private int contador=0;
        private const int MAX = 100;
        private double[] vector = new double[MAX];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (contador < MAX)
                {
                    vector[contador] = int.Parse(this.txtEntero.Text);
                    this.txtEntero.Text = "";
                    this.txtEntero.Focus();
                    MessageBox.Show("Elemento exitosamente agregado");
                    llenarLista();
                }
                contador++;
    }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void llenarLista()
        {
            //AGREGAR ELEMENTO AL LISTBOX
            this.lstNum.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                this.lstNum.Items.Add(vector[i]);
            }
        }

        private void btnMostrarRegistro_Click(object sender, EventArgs e)
        {
            llenarLista();
            this.txtSuma.Text = sumatoria().ToString();
            this.txtPromedio.Text = promedio().ToString();

            
        }
        private double sumatoria()
        {
            double suma = 0;
            for(int i = 0; i<contador;i++)
            {
                suma = suma + vector[i];
            }
            return suma;
        }
        private double promedio()
        {
            return (sumatoria() / contador);
        }



    }
}
