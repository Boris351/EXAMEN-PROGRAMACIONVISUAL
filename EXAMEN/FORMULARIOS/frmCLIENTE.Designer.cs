
namespace FORMULARIOS
{
    partial class frmCLIENTE
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
            this.GPBCLIENTE = new System.Windows.Forms.GroupBox();
            this.lblNumSeguroSocial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.txtNumSeg = new System.Windows.Forms.TextBox();
            this.DGVCLIENTES = new System.Windows.Forms.DataGridView();
            this.ApPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSeguroSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCLIENTE
            // 
            this.GPBCLIENTE.Controls.Add(this.txtNumSeg);
            this.GPBCLIENTE.Controls.Add(this.lblNumSeguroSocial);
            this.GPBCLIENTE.Controls.Add(this.txtNombre);
            this.GPBCLIENTE.Controls.Add(this.lblNombre);
            this.GPBCLIENTE.Controls.Add(this.txtCedula);
            this.GPBCLIENTE.Controls.Add(this.lblCedula);
            this.GPBCLIENTE.Controls.Add(this.btnGuardar);
            this.GPBCLIENTE.Controls.Add(this.cmbSexo);
            this.GPBCLIENTE.Controls.Add(this.cmbCategoria);
            this.GPBCLIENTE.Controls.Add(this.txtCodigoPedido);
            this.GPBCLIENTE.Controls.Add(this.txtApMaterno);
            this.GPBCLIENTE.Controls.Add(this.txtApPaterno);
            this.GPBCLIENTE.Controls.Add(this.lblCodigoPedido);
            this.GPBCLIENTE.Controls.Add(this.lblCategoria);
            this.GPBCLIENTE.Controls.Add(this.lblSexo);
            this.GPBCLIENTE.Controls.Add(this.lblApMaterno);
            this.GPBCLIENTE.Controls.Add(this.lblApPaterno);
            this.GPBCLIENTE.Location = new System.Drawing.Point(18, 17);
            this.GPBCLIENTE.Margin = new System.Windows.Forms.Padding(2);
            this.GPBCLIENTE.Name = "GPBCLIENTE";
            this.GPBCLIENTE.Padding = new System.Windows.Forms.Padding(2);
            this.GPBCLIENTE.Size = new System.Drawing.Size(1346, 222);
            this.GPBCLIENTE.TabIndex = 0;
            this.GPBCLIENTE.TabStop = false;
            this.GPBCLIENTE.Text = "CLIENTE";
            // 
            // lblNumSeguroSocial
            // 
            this.lblNumSeguroSocial.AutoSize = true;
            this.lblNumSeguroSocial.Location = new System.Drawing.Point(573, 118);
            this.lblNumSeguroSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumSeguroSocial.Name = "lblNumSeguroSocial";
            this.lblNumSeguroSocial.Size = new System.Drawing.Size(209, 17);
            this.lblNumSeguroSocial.TabIndex = 17;
            this.lblNumSeguroSocial.Text = "NUMERO DE SEGURO SOCIAL";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(405, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(402, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(405, 137);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(150, 23);
            this.txtCedula.TabIndex = 14;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(402, 118);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 17);
            this.lblCedula.TabIndex = 13;
            this.lblCedula.Text = "CEDULA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.btnGuardar.Location = new System.Drawing.Point(814, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 52);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(576, 60);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(110, 24);
            this.cmbSexo.TabIndex = 11;
            this.cmbSexo.Text = "FEMENINO";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.cmbCategoria.Location = new System.Drawing.Point(14, 137);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(140, 24);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.Text = "NUEVO";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(196, 137);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(150, 23);
            this.txtCodigoPedido.TabIndex = 9;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(196, 60);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(142, 23);
            this.txtApMaterno.TabIndex = 6;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(14, 60);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(139, 23);
            this.txtApPaterno.TabIndex = 5;
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(193, 118);
            this.lblCodigoPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(142, 17);
            this.lblCodigoPedido.TabIndex = 4;
            this.lblCodigoPedido.Text = "CODIGO DE PEDIDO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 118);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(573, 41);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 17);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "SEXO";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(193, 41);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(148, 17);
            this.lblApMaterno.TabIndex = 1;
            this.lblApMaterno.Text = "APELLIDO MATERNO";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(11, 41);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(146, 17);
            this.lblApPaterno.TabIndex = 0;
            this.lblApPaterno.Text = "APELLIDO PATERNO";
            // 
            // txtNumSeg
            // 
            this.txtNumSeg.Location = new System.Drawing.Point(576, 138);
            this.txtNumSeg.Name = "txtNumSeg";
            this.txtNumSeg.Size = new System.Drawing.Size(206, 23);
            this.txtNumSeg.TabIndex = 18;
            // 
            // DGVCLIENTES
            // 
            this.DGVCLIENTES.AllowUserToAddRows = false;
            this.DGVCLIENTES.AllowUserToOrderColumns = true;
            this.DGVCLIENTES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.DGVCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCLIENTES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApPaterno,
            this.ApMaterno,
            this.Nombre,
            this.Sexo,
            this.Categoria,
            this.CodigoPedido,
            this.Cedula,
            this.NumSeguroSocial});
            this.DGVCLIENTES.Location = new System.Drawing.Point(18, 245);
            this.DGVCLIENTES.Name = "DGVCLIENTES";
            this.DGVCLIENTES.Size = new System.Drawing.Size(1346, 150);
            this.DGVCLIENTES.TabIndex = 1;
            // 
            // ApPaterno
            // 
            this.ApPaterno.HeaderText = "APELLIDO PATERNO";
            this.ApPaterno.Name = "ApPaterno";
            this.ApPaterno.Width = 200;
            // 
            // ApMaterno
            // 
            this.ApMaterno.HeaderText = "APELLIDO MATERNO";
            this.ApMaterno.Name = "ApMaterno";
            this.ApMaterno.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 150;
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.HeaderText = "CODIGO DE PEDIDO";
            this.CodigoPedido.Name = "CodigoPedido";
            this.CodigoPedido.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CEDULA";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 150;
            // 
            // NumSeguroSocial
            // 
            this.NumSeguroSocial.HeaderText = "NUMERO DE SEGURO SOCIAL";
            this.NumSeguroSocial.Name = "NumSeguroSocial";
            this.NumSeguroSocial.Width = 150;
            // 
            // frmCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1364, 401);
            this.Controls.Add(this.DGVCLIENTES);
            this.Controls.Add(this.GPBCLIENTE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.frmCLIENTE_Load);
            this.GPBCLIENTE.ResumeLayout(false);
            this.GPBCLIENTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCLIENTE;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNumSeguroSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumSeg;
        private System.Windows.Forms.DataGridView DGVCLIENTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSeguroSocial;
    }
}