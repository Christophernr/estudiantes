namespace formualarios
{
    partial class AgregarAlumnos
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
            txtBuscar = new TextBox();
            dataListadoAsistencia = new DataGridView();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cbSeccion = new ComboBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataListadoAsistencia).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(189, 224, 254);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(418, 335);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(224, 34);
            txtBuscar.TabIndex = 67;
            // 
            // dataListadoAsistencia
            // 
            dataListadoAsistencia.BackgroundColor = Color.FromArgb(189, 224, 254);
            dataListadoAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListadoAsistencia.Location = new Point(29, 381);
            dataListadoAsistencia.Margin = new Padding(3, 4, 3, 4);
            dataListadoAsistencia.Name = "dataListadoAsistencia";
            dataListadoAsistencia.RowHeadersWidth = 51;
            dataListadoAsistencia.Size = new Size(858, 156);
            dataListadoAsistencia.TabIndex = 66;
            dataListadoAsistencia.DoubleClick += dataListadoAsistencia_DoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(189, 224, 254);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(32, 329);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 44);
            btnEliminar.TabIndex = 65;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(189, 224, 254);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(640, 173);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 47);
            btnLimpiar.TabIndex = 64;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(189, 224, 254);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(640, 119);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(167, 47);
            btnModificar.TabIndex = 63;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(189, 224, 254);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(640, 64);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 47);
            btnGuardar.TabIndex = 62;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbSeccion
            // 
            cbSeccion.BackColor = Color.FromArgb(189, 224, 254);
            cbSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeccion.FlatStyle = FlatStyle.Popup;
            cbSeccion.FormattingEnabled = true;
            cbSeccion.Location = new Point(122, 235);
            cbSeccion.Margin = new Padding(3, 4, 3, 4);
            cbSeccion.Name = "cbSeccion";
            cbSeccion.Size = new Size(134, 28);
            cbSeccion.TabIndex = 61;
            cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(189, 224, 254);
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.Location = new Point(122, 181);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(114, 27);
            txtApellidos.TabIndex = 60;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(189, 224, 254);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(122, 123);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 59;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(189, 224, 254);
            txtCedula.BorderStyle = BorderStyle.FixedSingle;
            txtCedula.Location = new Point(122, 72);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(114, 27);
            txtCedula.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 239);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 57;
            label4.Text = "Sección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 181);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 56;
            label3.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 127);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 55;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 54;
            label1.Text = "Cédula";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(189, 224, 254);
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(122, 24);
            txt_id.Margin = new Padding(3, 4, 3, 4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(114, 27);
            txt_id.TabIndex = 69;
            // 
            // AgregarAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 210, 255);
            ClientSize = new Size(914, 600);
            Controls.Add(txt_id);
            Controls.Add(txtBuscar);
            Controls.Add(dataListadoAsistencia);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cbSeccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarAlumnos";
            Text = "AgregarAsistencia";
            Load += AgregarAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataListadoAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscar;
        private DataGridView dataListadoAsistencia;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_id;
        private ComboBox cbSeccion;
    }
}