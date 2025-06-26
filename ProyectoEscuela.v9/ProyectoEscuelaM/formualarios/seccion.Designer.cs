namespace formualarios
{
    partial class seccion
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
            textBox5 = new TextBox();
            txtBuscar = new TextBox();
            dataListadoSeccion = new DataGridView();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtSeccion = new TextBox();
            label1 = new Label();
            label_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dataListadoSeccion).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(189, 224, 254);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(360, 335);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 34);
            textBox5.TabIndex = 83;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(189, 224, 254);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(129, 335);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(224, 34);
            txtBuscar.TabIndex = 82;
            // 
            // dataListadoSeccion
            // 
            dataListadoSeccion.BackgroundColor = Color.FromArgb(189, 224, 254);
            dataListadoSeccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListadoSeccion.Location = new Point(129, 377);
            dataListadoSeccion.Margin = new Padding(3, 4, 3, 4);
            dataListadoSeccion.Name = "dataListadoSeccion";
            dataListadoSeccion.RowHeadersWidth = 51;
            dataListadoSeccion.Size = new Size(647, 221);
            dataListadoSeccion.TabIndex = 81;
            dataListadoSeccion.CellContentClick += dataListadoSeccion_CellContentClick;
            dataListadoSeccion.DoubleClick += dataListadoSeccion_DoubleClick;
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
            btnEliminar.TabIndex = 80;
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
            btnLimpiar.TabIndex = 79;
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
            btnModificar.Size = new Size(192, 47);
            btnModificar.TabIndex = 78;
            btnModificar.Text = "Guardar Cambios";
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
            btnGuardar.TabIndex = 77;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSeccion
            // 
            txtSeccion.BackColor = Color.FromArgb(189, 224, 254);
            txtSeccion.BorderStyle = BorderStyle.FixedSingle;
            txtSeccion.Location = new Point(122, 72);
            txtSeccion.Margin = new Padding(3, 4, 3, 4);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(114, 27);
            txtSeccion.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 76);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 69;
            label1.Text = "Sección";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(151, 31);
            label_id.Name = "label_id";
            label_id.Size = new Size(50, 20);
            label_id.TabIndex = 84;
            label_id.Text = "label2";
            // 
            // seccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 210, 255);
            ClientSize = new Size(933, 617);
            Controls.Add(label_id);
            Controls.Add(textBox5);
            Controls.Add(txtBuscar);
            Controls.Add(dataListadoSeccion);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtSeccion);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "seccion";
            Text = "Sección";
            Load += seccion_Load;
            ((System.ComponentModel.ISupportInitialize)dataListadoSeccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox txtBuscar;
        private DataGridView dataListadoSeccion;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtSeccion;
        private Label label1;
        private Label label_id;
    }
}