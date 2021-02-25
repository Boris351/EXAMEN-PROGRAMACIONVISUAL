
namespace FORMULARIOS
{
    partial class frmEMPLEADOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbmCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.Controls.Add(this.txtSueldo);
            this.GboEmpleados.Controls.Add(this.lblSueldo);
            this.GboEmpleados.Controls.Add(this.cbmCategoria);
            this.GboEmpleados.Controls.Add(this.lblCategoria);
            this.GboEmpleados.Controls.Add(this.txtNombre);
            this.GboEmpleados.Controls.Add(this.lblNombre);
            this.GboEmpleados.Controls.Add(this.txtCedula);
            this.GboEmpleados.Controls.Add(this.lblCedula);
            this.GboEmpleados.Controls.Add(this.btnGuardar);
            this.GboEmpleados.Controls.Add(this.cboTipoContrato);
            this.GboEmpleados.Controls.Add(this.cboSexo);
            this.GboEmpleados.Controls.Add(this.txtApMaterno);
            this.GboEmpleados.Controls.Add(this.txtApPaterno);
            this.GboEmpleados.Controls.Add(this.lblApMaterno);
            this.GboEmpleados.Controls.Add(this.lblSexo);
            this.GboEmpleados.Controls.Add(this.lblTipoContrato);
            this.GboEmpleados.Controls.Add(this.lblApPaterno);
            this.GboEmpleados.Location = new System.Drawing.Point(24, 15);
            this.GboEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.GboEmpleados.Size = new System.Drawing.Size(1238, 221);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "Empleados";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(457, 138);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(156, 23);
            this.txtCedula.TabIndex = 17;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(454, 109);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 17);
            this.lblCedula.TabIndex = 16;
            this.lblCedula.Text = "CEDULA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.btnGuardar.Location = new System.Drawing.Point(839, 109);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 52);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.cboTipoContrato.Location = new System.Drawing.Point(30, 137);
            this.cboTipoContrato.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(150, 24);
            this.cboTipoContrato.TabIndex = 14;
            this.cboTipoContrato.Text = "NUEVO";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(666, 62);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(150, 24);
            this.cboSexo.TabIndex = 12;
            this.cboSexo.Text = "FEMENINO";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(230, 62);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(156, 23);
            this.txtApMaterno.TabIndex = 9;
            this.txtApMaterno.TextChanged += new System.EventHandler(this.txtApMaterno_TextChanged);
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(30, 63);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(143, 23);
            this.txtApPaterno.TabIndex = 8;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(227, 41);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(148, 17);
            this.lblApMaterno.TabIndex = 7;
            this.lblApMaterno.Text = "APELLIDO MATERNO";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(663, 41);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "SEXO";
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(27, 109);
            this.lblTipoContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(145, 17);
            this.lblTipoContrato.TabIndex = 2;
            this.lblTipoContrato.Text = "TIPO DE CONTRATO";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(27, 42);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(146, 17);
            this.lblApPaterno.TabIndex = 0;
            this.lblApPaterno.Text = "APELLIDO PATERNO";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.AllowUserToOrderColumns = true;
            this.DGVEMPLEADOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.Nombre,
            this.SEXO,
            this.TIPOCONTRATO,
            this.Categoria,
            this.CEDULA,
            this.SUELDO});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(24, 244);
            this.DGVEMPLEADOS.Margin = new System.Windows.Forms.Padding(4);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.RowHeadersWidth = 51;
            this.DGVEMPLEADOS.RowTemplate.Height = 24;
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(1238, 150);
            this.DGVEMPLEADOS.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(457, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(454, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "NOMBRE";
            // 
            // cbmCategoria
            // 
            this.cbmCategoria.FormattingEnabled = true;
            this.cbmCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.cbmCategoria.Location = new System.Drawing.Point(230, 138);
            this.cbmCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbmCategoria.Name = "cbmCategoria";
            this.cbmCategoria.Size = new System.Drawing.Size(140, 24);
            this.cbmCategoria.TabIndex = 21;
            this.cbmCategoria.Text = "NUEVO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(227, 109);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 17);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 220;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 220;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 125;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.MinimumWidth = 6;
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 175;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CÉDULA";
            this.CEDULA.MinimumWidth = 6;
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 125;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 6;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 125;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(663, 109);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(65, 17);
            this.lblSueldo.TabIndex = 22;
            this.lblSueldo.Text = "SUELDO";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(666, 137);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(156, 23);
            this.txtSueldo.TabIndex = 23;
            // 
            // frmEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1275, 435);
            this.Controls.Add(this.DGVEMPLEADOS);
            this.Controls.Add(this.GboEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEMPLEADOS";
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbmCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
    }
}