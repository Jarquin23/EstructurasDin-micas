using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinámicas.Formularios
{
    public partial class FrmPila : Form
    {
        Stack<int> pila = new Stack<int>(); //creación de pila
        public FrmPila()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int elemento = int.Parse(tbNumero.Text);
            pila.Push(elemento); //Agregar un elemento

            lblPila.Text = MostrarElementos();
            tbNumero.Clear();
            tbNumero.Focus();
        }
        private string MostrarElementos()
        {
            string msn = "";
            foreach (int i in pila)
            {
                msn += " " + i.ToString() + " |";
            }
            return msn;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                pila.Pop();
                lblPila.Text = MostrarElementos();
            }catch (InvalidOperationException)
            {
                MessageBox.Show("estimado usuario, no se pueden eliminar elementos, porque la pila está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnMostrarUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"{pila.Peek()}", "Ultimo elemento ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(InvalidOperationException)
            {
                MessageBox.Show("Pila vacía", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
