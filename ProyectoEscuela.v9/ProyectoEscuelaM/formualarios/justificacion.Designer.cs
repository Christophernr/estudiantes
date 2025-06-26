namespace formualarios
{
    partial class justificacion
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
            txt_nombre = new TextBox();
            textoMotivo = new RichTextBox();
            tablaNOjustificados = new DataGridView();
            btn_justificar = new Button();
            btn_volver = new Button();
            txt_apellidos = new TextBox();
            cb_justificar = new ComboBox();
            lbl_fecha = new Label();
            lbl_id_asistencia = new Label();
            lbl_id_estudiante = new Label();
            calendario = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)tablaNOjustificados).BeginInit();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(91, 76);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(113, 27);
            txt_nombre.TabIndex = 1;
            // 
            // textoMotivo
            // 
            textoMotivo.Location = new Point(12, 163);
            textoMotivo.Name = "textoMotivo";
            textoMotivo.Size = new Size(333, 120);
            textoMotivo.TabIndex = 3;
            textoMotivo.Text = "";
            // 
            // tablaNOjustificados
            // 
            tablaNOjustificados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaNOjustificados.Location = new Point(2, 331);
            tablaNOjustificados.Name = "tablaNOjustificados";
            tablaNOjustificados.RowHeadersWidth = 51;
            tablaNOjustificados.Size = new Size(839, 172);
            tablaNOjustificados.TabIndex = 4;
            tablaNOjustificados.DoubleClick += tablaNOjustificados_DoubleClick;
            // 
            // btn_justificar
            // 
            btn_justificar.Location = new Point(725, 24);
            btn_justificar.Name = "btn_justificar";
            btn_justificar.Size = new Size(102, 36);
            btn_justificar.TabIndex = 5;
            btn_justificar.Text = "Justificar";
            btn_justificar.UseVisualStyleBackColor = true;
            btn_justificar.Click += btn_justificar_Click;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(725, 79);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(102, 36);
            btn_volver.TabIndex = 6;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // txt_apellidos
            // 
            txt_apellidos.Location = new Point(91, 120);
            txt_apellidos.Name = "txt_apellidos";
            txt_apellidos.Size = new Size(125, 27);
            txt_apellidos.TabIndex = 8;
            // 
            // cb_justificar
            // 
            cb_justificar.FormattingEnabled = true;
            cb_justificar.Location = new Point(91, 12);
            cb_justificar.Name = "cb_justificar";
            cb_justificar.Size = new Size(40, 28);
            cb_justificar.TabIndex = 9;
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(417, 79);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(0, 20);
            lbl_fecha.TabIndex = 10;
            // 
            // lbl_id_asistencia
            // 
            lbl_id_asistencia.AutoSize = true;
            lbl_id_asistencia.Location = new Point(113, 27);
            lbl_id_asistencia.Name = "lbl_id_asistencia";
            lbl_id_asistencia.Size = new Size(0, 20);
            lbl_id_asistencia.TabIndex = 11;
            // 
            // lbl_id_estudiante
            // 
            lbl_id_estudiante.AutoSize = true;
            lbl_id_estudiante.Location = new Point(294, 24);
            lbl_id_estudiante.Name = "lbl_id_estudiante";
            lbl_id_estudiante.Size = new Size(0, 20);
            lbl_id_estudiante.TabIndex = 12;
            // 
            // calendario
            // 
            calendario.Location = new Point(393, 24);
            calendario.Name = "calendario";
            calendario.TabIndex = 13;
            calendario.DateChanged += calendario_DateChanged_1;
            // 
            // justificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(839, 501);
            Controls.Add(calendario);
            Controls.Add(lbl_id_estudiante);
            Controls.Add(lbl_id_asistencia);
            Controls.Add(lbl_fecha);
            Controls.Add(cb_justificar);
            Controls.Add(txt_apellidos);
            Controls.Add(btn_volver);
            Controls.Add(btn_justificar);
            Controls.Add(tablaNOjustificados);
            Controls.Add(textoMotivo);
            Controls.Add(txt_nombre);
            Name = "justificacion";
            Text = "justificacion";
            ((System.ComponentModel.ISupportInitialize)tablaNOjustificados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre;
        private RichTextBox textoMotivo;
        private DataGridView tablaNOjustificados;
        private Button btn_justificar;
        private Button btn_volver;
        private TextBox txt_apellidos;
        private ComboBox cb_justificar;
        private Label lbl_fecha;
        private Label lbl_id_asistencia;
        private Label lbl_id_estudiante;
        private MonthCalendar calendario;
    }
}