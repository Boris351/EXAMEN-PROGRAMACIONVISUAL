using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class frmPORTADA : Form
    {
        public frmPORTADA()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            FORMULARIOS.frmPORTADA PORTADA = new FORMULARIOS.frmPORTADA();
            PORTADA.ShowDialog();

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FORMULARIOS.frmCLIENTE CLIENTE = new FORMULARIOS.frmCLIENTE();
            CLIENTE.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            FORMULARIOS.frmEMPLEADOS EMPLEADOS = new FORMULARIOS.frmEMPLEADOS();
            EMPLEADOS.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
