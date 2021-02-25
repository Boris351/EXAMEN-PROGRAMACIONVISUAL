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
    public partial class frmCLIENTE : Form
    {
        public frmCLIENTE()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.CLIENTE CLIENTE1 = new CLASES.CLIENTE();

            CLIENTE1.CEDULAS1 = txtCedula.Text;
            CLIENTE1.GENERARLISTACEDULAS();
            txtCedula.Text = CLIENTE1.CEDULAS1;


            CLIENTE1.APPATERNO1 = txtApPaterno.Text;
            CLIENTE1.APMATERNO1 = txtApMaterno.Text;
            CLIENTE1.NOMBRE1 = txtNombre.Text;
            CLIENTE1.NUMEROSEGURIDADSOCIAL1 = txtNumSeg.Text;
            CLIENTE1.SEXO1 = cmbSexo.Text;
            CLIENTE1.CATEGORIA1 = cmbCategoria.Text;
            CLIENTE1.GENERARCODIGODEPEDIDO();
            txtCodigoPedido.Text = CLIENTE1.CODIGODEPEDIDO1;
            DGVCLIENTES.Rows.Insert(0, CLIENTE1.APPATERNO1, CLIENTE1.APMATERNO1, CLIENTE1.NOMBRE1, CLIENTE1.SEXO1, CLIENTE1.NUMEROSEGURIDADSOCIAL1, CLIENTE1.CATEGORIA1, CLIENTE1.CODIGODEPEDIDO1, CLIENTE1.CEDULAS1);
            
        
        }

        private void frmCLIENTE_Load(object sender, EventArgs e)
        {

        }
    }
}
