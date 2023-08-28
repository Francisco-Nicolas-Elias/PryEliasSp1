using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PryEliasSp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivito, false");
                MessageBox.Show("Archivo creado");
            }
            catch
            {
                MessageBox.Show("Fatal error");
            }
        }

        private void btnGrabarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("miArchivito", true);
                swManejoArchivo.WriteLine(txtDatos.Text);
                swManejoArchivo.Close();
                MessageBox.Show("Almacenado");
                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fatal error" + ex.Message);
            }
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("miArchivito");

            while(srManejoArchivo.EndOfStream == false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }
            srManejoArchivo.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = "";
        }
    }
}
