using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Conjuntos
{
    public partial class FrmConjuntoDoble : Form
    {
        //Declaracion de los arrays
        private HashSet<string> conjuntoA = new HashSet<string>();
        private HashSet<string> conjuntoB = new HashSet<string>();
        private HashSet<string> unionAB = new HashSet<string>();
        private HashSet<string> interseccionAB = new HashSet<string>();
        private HashSet<string> diferenciaAB = new HashSet<string>();
        private HashSet<string> diferenciaBA = new HashSet<string>();
        private HashSet<string> diferenciaSimetrica = new HashSet<string>();
        ConjuntoDoble conjunto;


        public FrmConjuntoDoble()
        {
            InitializeComponent();
        }



        public void obtenerElementosConjuntoA()
        {
            for (int i=0; i< this.txtConjuntoA.Lines.Count(); i++)
            {
                this.conjuntoA.Add(this.txtConjuntoA.Lines[i]);
            }
        }



        public void obtenerElementosConjuntoB()
        {
            for (int i = 0; i < this.txtConjuntoB.Lines.Count(); i++)
            {
                this.conjuntoB.Add(this.txtConjuntoB.Lines[i]);
            }
        }



        string auxiliarEspacio;
        private void cerraduraKleene()
        {
            String cadena = txtConjuntoA.Text;
            auxiliarEspacio = "";
            String[] cadenaResultante = cadena.Split('\n');

            for (int i = 0; i < cadenaResultante.Length; i++)
            {
                auxiliarEspacio = auxiliarEspacio + cadenaResultante[i] + ",";
            }


            for (int i = 0; i < cadenaResultante.Length; i++)
            {
                for (int j = 0; j < cadenaResultante.Length; j++)
                {
                    auxiliarEspacio = auxiliarEspacio + cadenaResultante[i] + cadenaResultante[j] + ",";
                }
            }


            for (int i = 0; i < cadenaResultante.Length; i++)
            {
                for (int j = 0; j < cadenaResultante.Length; j++)
                {
                    for (int k = 0; k < cadenaResultante.Length; k++)
                    {
                        auxiliarEspacio = auxiliarEspacio + cadenaResultante[i] + cadenaResultante[j] + cadenaResultante[k] + ",";
                    }
                }
            }


            txtKleene.Text = " {E,"+auxiliarEspacio+", ... OO}";
        }
       



        private void btnOperar_Click(object sender, EventArgs e)
        {
            cerraduraKleene();
            obtenerElementosConjuntoA();
            obtenerElementosConjuntoB();
            conjunto = new ConjuntoDoble(this.conjuntoA,this.conjuntoB);
            unionAB = conjunto.Union();
            interseccionAB = conjunto.Interseccion();
            diferenciaAB = conjunto.DiferenciaAB();
            diferenciaBA = conjunto.operarDiferenciaBA();
            diferenciaSimetrica = conjunto.DiferenciaSimetrica();
            mostrarResultados();

            this.txtUnionAB.Enabled = false;
            this.txtInterseccionAB.Enabled = false;
            this.txtDiferenciaAB.Enabled = false;
            this.txtDiferenciaBA.Enabled = false;
            this.txtSimetricaAB.Enabled = false;
        }



        public void mostrarResultados()
        {
            if (unionAB.Count == 0)
            {
                this.txtUnionAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in unionAB)
                {
                    this.txtUnionAB.Text += (elemento + ", ");
                }
            }

            if (interseccionAB.Count == 0)
            {
                this.txtInterseccionAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in interseccionAB)
                {
                    this.txtInterseccionAB.Text += (elemento + ", ");
                }
            }

            if (diferenciaAB.Count == 0)
            {
                this.txtDiferenciaAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in diferenciaAB)
                {
                    this.txtDiferenciaAB.Text += (elemento + ", ");
                }
            }

            if (diferenciaBA.Count == 0)
            {
                this.txtDiferenciaBA.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in diferenciaBA)
                {
                    this.txtDiferenciaBA.Text += (elemento + ", ");
                }
            }

            if (diferenciaSimetrica.Count == 0)
            {
                this.txtSimetricaAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in diferenciaSimetrica)
                {
                    this.txtSimetricaAB.Text += (elemento + ", ");
                }
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }




        public void limpiar()
        {

            this.txtConjuntoA.Enabled = true;
            this.txtConjuntoB.Enabled = true;
            this.txtUnionAB.Enabled = true;
            this.txtInterseccionAB.Enabled = true;
            this.txtDiferenciaAB.Enabled = true;
            this.txtDiferenciaBA.Enabled = true;
            this.txtSimetricaAB.Enabled = true;

            txtPositivo.Text = "";
            txtKleene.Text = "";
            this.txtConjuntoA.Clear();
            this.txtConjuntoB.Clear();
            txtUnionAB.Text = "";
            txtInterseccionAB.Text = "";
            txtDiferenciaAB.Text = "";
            txtDiferenciaBA.Text = "";
            txtSimetricaAB.Text = "";

            this.conjuntoA.Clear();
            this.conjuntoB.Clear();
            this.unionAB.Clear();
            this.interseccionAB.Clear();
            this.diferenciaAB.Clear();
            this.diferenciaBA.Clear();
            this.diferenciaSimetrica.Clear();
            this.txtConjuntoA.Focus();
        }



        private void FrmConjuntoDoble_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtConjuntoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnionAB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKleene_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterseccionAB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiferenciaAB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtConjuntoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDiferenciaBA_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSimetricaAB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}