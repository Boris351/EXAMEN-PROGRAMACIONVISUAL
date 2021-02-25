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
    public partial class frmEMPLEADOS : Form
    {
        public frmEMPLEADOS()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.EMPLEADO EMPLEADO1 = new CLASES.EMPLEADO();
            EMPLEADO1.CEDULA1 = txtCedula.Text;
            EMPLEADO1.GENERARLISTACEDULA();
            txtCedula.Text = EMPLEADO1.CEDULA1;

            EMPLEADO1.APPATERNO1 = txtApPaterno.Text;
            EMPLEADO1.APMATERNO1 = txtApMaterno.Text;
            EMPLEADO1.NOMBRE1 = txtNombre.Text;
            EMPLEADO1.SEXO1 = cboSexo.Text;
            EMPLEADO1.TIPOCONTRATO1 = cboTipoContrato.Text;
            EMPLEADO1.TIPO1 = cbmCategoria.Text;
            EMPLEADO1.CEDULA1 = txtCedula.Text;
            EMPLEADO1.CALCULARSUELDO(1250);
            DGVEMPLEADOS.Rows.Insert(0, EMPLEADO1.APPATERNO1, EMPLEADO1.APMATERNO1, EMPLEADO1.NOMBRE1, EMPLEADO1.SEXO1, EMPLEADO1.TIPOCONTRATO1, EMPLEADO1.TIPO1, EMPLEADO1.CEDULA1, EMPLEADO1.SUELDO1);
                       
        }

        private void txtApMaterno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
