using MyApp.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona personas = new Persona();
            Persona.Nombre = tbNombre.Text;
            Persona.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(Persona.EvaluarEdad());
        }
    }
}
