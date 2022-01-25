
namespace CCTPPR
{
    partial class Aportaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotipD = new System.Windows.Forms.ComboBox();
            this.cboañoA = new System.Windows.Forms.ComboBox();
            this.cbomesA = new System.Windows.Forms.ComboBox();
            this.txtsoc = new System.Windows.Forms.TextBox();
            this.txtnroD = new System.Windows.Forms.TextBox();
            this.txtcodA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.txtdaS = new System.Windows.Forms.TextBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.btnbuscar = new Guna.UI.WinForms.GunaImageButton();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunaImageButton1);
            this.groupBox1.Controls.Add(this.txtdaS);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbotipD);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbomesA);
            this.groupBox1.Controls.Add(this.cboañoA);
            this.groupBox1.Controls.Add(this.txtsoc);
            this.groupBox1.Controls.Add(this.txtnroD);
            this.groupBox1.Controls.Add(this.txtcodA);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 254);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las Aportaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Codigo del Socio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nroº de Documento:";
            // 
            // cbotipD
            // 
            this.cbotipD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cbotipD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotipD.ForeColor = System.Drawing.Color.White;
            this.cbotipD.FormattingEnabled = true;
            this.cbotipD.Items.AddRange(new object[] {
            "<Seleccione el Tipo de Documento>",
            "Boleta",
            "Factura",
            "Comprobante de Pago"});
            this.cbotipD.Location = new System.Drawing.Point(176, 140);
            this.cbotipD.Name = "cbotipD";
            this.cbotipD.Size = new System.Drawing.Size(512, 28);
            this.cbotipD.TabIndex = 40;
            // 
            // cboañoA
            // 
            this.cboañoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cboañoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboañoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboañoA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboañoA.ForeColor = System.Drawing.Color.White;
            this.cboañoA.FormattingEnabled = true;
            this.cboañoA.Items.AddRange(new object[] {
            "<Seleccione el Año>",
            "2020",
            "2021",
            "2022"});
            this.cboañoA.Location = new System.Drawing.Point(176, 72);
            this.cboañoA.Name = "cboañoA";
            this.cboañoA.Size = new System.Drawing.Size(512, 28);
            this.cboañoA.TabIndex = 39;
            // 
            // cbomesA
            // 
            this.cbomesA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cbomesA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbomesA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomesA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbomesA.ForeColor = System.Drawing.Color.White;
            this.cbomesA.FormattingEnabled = true;
            this.cbomesA.Items.AddRange(new object[] {
            "<Seleccione el Mes>",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbomesA.Location = new System.Drawing.Point(176, 106);
            this.cbomesA.MaxDropDownItems = 20;
            this.cbomesA.Name = "cbomesA";
            this.cbomesA.Size = new System.Drawing.Size(512, 28);
            this.cbomesA.TabIndex = 38;
            // 
            // txtsoc
            // 
            this.txtsoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtsoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoc.ForeColor = System.Drawing.Color.White;
            this.txtsoc.Location = new System.Drawing.Point(176, 209);
            this.txtsoc.Name = "txtsoc";
            this.txtsoc.ReadOnly = true;
            this.txtsoc.Size = new System.Drawing.Size(176, 29);
            this.txtsoc.TabIndex = 37;
            // 
            // txtnroD
            // 
            this.txtnroD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtnroD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroD.ForeColor = System.Drawing.Color.White;
            this.txtnroD.Location = new System.Drawing.Point(176, 174);
            this.txtnroD.Name = "txtnroD";
            this.txtnroD.Size = new System.Drawing.Size(512, 29);
            this.txtnroD.TabIndex = 36;
            // 
            // txtcodA
            // 
            this.txtcodA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtcodA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodA.ForeColor = System.Drawing.Color.White;
            this.txtcodA.Location = new System.Drawing.Point(176, 37);
            this.txtcodA.Name = "txtcodA";
            this.txtcodA.ReadOnly = true;
            this.txtcodA.Size = new System.Drawing.Size(437, 29);
            this.txtcodA.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cod. Aporte:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Mes de Aporte:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Año de Aporte:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tipo de Documento:";
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AllowUserToDeleteRows = false;
            this.dgvdatos.AllowUserToResizeColumns = false;
            this.dgvdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.dgvdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatos.ColumnHeadersHeight = 45;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvdatos.EnableHeadersVisualStyles = false;
            this.dgvdatos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdatos.Location = new System.Drawing.Point(15, 479);
            this.dgvdatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdatos.RowHeadersVisible = false;
            this.dgvdatos.RowHeadersWidth = 55;
            this.dgvdatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdatos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvdatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgvdatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatos.Size = new System.Drawing.Size(1240, 467);
            this.dgvdatos.TabIndex = 28;
            this.dgvdatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellClick);
            // 
            // txtdaS
            // 
            this.txtdaS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtdaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdaS.ForeColor = System.Drawing.Color.White;
            this.txtdaS.Location = new System.Drawing.Point(358, 209);
            this.txtdaS.Name = "txtdaS";
            this.txtdaS.ReadOnly = true;
            this.txtdaS.Size = new System.Drawing.Size(255, 29);
            this.txtdaS.TabIndex = 43;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::CCTPPR.Properties.Resources.search_64px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(619, 209);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(69, 29);
            this.gunaImageButton1.TabIndex = 44;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnbuscar.Image = global::CCTPPR.Properties.Resources.search_64px;
            this.btnbuscar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnbuscar.Location = new System.Drawing.Point(619, 37);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.OnHoverImage = null;
            this.btnbuscar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(69, 29);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::CCTPPR.Properties.Resources.delete_document_32px;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(994, 409);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btneliminar.Size = new System.Drawing.Size(222, 37);
            this.btneliminar.TabIndex = 26;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Image = global::CCTPPR.Properties.Resources.update;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(744, 409);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnactualizar.Size = new System.Drawing.Size(222, 37);
            this.btnactualizar.TabIndex = 25;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Image = global::CCTPPR.Properties.Resources.add_pie_chart_report_24px;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(484, 409);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnagregar.Size = new System.Drawing.Size(222, 37);
            this.btnagregar.TabIndex = 24;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Image = global::CCTPPR.Properties.Resources.icons8_archivo_nuevo_24;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(15, 409);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnnuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnuevo.Size = new System.Drawing.Size(222, 37);
            this.btnnuevo.TabIndex = 23;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cod_apor";
            this.Column1.HeaderText = "Cod. Aporte";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "año_apor";
            this.Column3.HeaderText = "Año de Aporte";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mes_apor";
            this.Column2.HeaderText = "Mes de Aporte";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tip_doc";
            this.Column4.HeaderText = "Tipo de Documento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nro_doc";
            this.Column5.HeaderText = "No° Documento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cod_soc";
            this.Column6.HeaderText = "Codigo del Socio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Aportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1264, 971);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnnuevo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "Aportaciones";
            this.Text = "Aportaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Aportaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsoc;
        private System.Windows.Forms.TextBox txtnroD;
        private System.Windows.Forms.TextBox txtcodA;
        private System.Windows.Forms.ComboBox cbotipD;
        private System.Windows.Forms.ComboBox cboañoA;
        private System.Windows.Forms.ComboBox cbomesA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdatos;
        private Guna.UI.WinForms.GunaImageButton btnbuscar;
        private System.Windows.Forms.TextBox txtdaS;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}