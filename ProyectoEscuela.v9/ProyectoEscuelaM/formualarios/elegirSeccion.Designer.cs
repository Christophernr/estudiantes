namespace formualarios
{
    partial class elegirSeccion
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
            seleccion_seccion = new Button();
            combo_eleccion_seccion = new ComboBox();
            btnAgregar = new Button();
            agregarSeccion = new Button();
            SuspendLayout();
            // 
            // seleccion_seccion
            // 
            seleccion_seccion.BackColor = Color.FromArgb(189, 224, 254);
            seleccion_seccion.FlatStyle = FlatStyle.Popup;
            seleccion_seccion.Location = new Point(559, 93);
            seleccion_seccion.Name = "seleccion_seccion";
            seleccion_seccion.Size = new Size(101, 44);
            seleccion_seccion.TabIndex = 0;
            seleccion_seccion.Text = "seleccionar";
            seleccion_seccion.UseVisualStyleBackColor = false;
            seleccion_seccion.Click += seleccion_seccion_Click;
            // 
            // combo_eleccion_seccion
            // 
            combo_eleccion_seccion.BackColor = Color.FromArgb(189, 224, 254);
            combo_eleccion_seccion.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_eleccion_seccion.FlatStyle = FlatStyle.Popup;
            combo_eleccion_seccion.FormattingEnabled = true;
            combo_eleccion_seccion.Location = new Point(93, 67);
            combo_eleccion_seccion.Name = "combo_eleccion_seccion";
            combo_eleccion_seccion.Size = new Size(151, 28);
            combo_eleccion_seccion.TabIndex = 1;
            combo_eleccion_seccion.SelectedIndexChanged += combo_eleccion_seccion_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(189, 224, 254);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(150, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 87);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Estudiantes";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // agregarSeccion
            // 
            agregarSeccion.BackColor = Color.FromArgb(189, 224, 254);
            agregarSeccion.FlatStyle = FlatStyle.Popup;
            agregarSeccion.Location = new Point(482, 285);
            agregarSeccion.Name = "agregarSeccion";
            agregarSeccion.Size = new Size(149, 85);
            agregarSeccion.TabIndex = 3;
            agregarSeccion.Text = "Agregar Secciones";
            agregarSeccion.UseVisualStyleBackColor = false;
            agregarSeccion.Click += agregarSeccion_Click;
            // 
            // elegirSeccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 210, 255);
            ClientSize = new Size(800, 451);
            Controls.Add(agregarSeccion);
            Controls.Add(btnAgregar);
            Controls.Add(combo_eleccion_seccion);
            Controls.Add(seleccion_seccion);
            Name = "elegirSeccion";
            Text = "elegirSeccion";
            Load += elegirSeccion_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button seleccion_seccion;
        private ComboBox combo_eleccion_seccion;
        private Button btnAgregar;
        private Button agregarSeccion;
    }
}