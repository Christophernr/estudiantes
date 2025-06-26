namespace formualarios
{
    partial class Alumnos
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
            label2 = new Label();
            label1 = new Label();
            estudianteGridView = new DataGridView();
            TomarAsistencia = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_justificar = new Button();
            btn_volver = new Button();
            ((System.ComponentModel.ISupportInitialize)estudianteGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(189, 224, 254);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 48);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(136, 34);
            label2.TabIndex = 6;
            label2.Text = "Asistencias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(189, 224, 254);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(137, 34);
            label1.TabIndex = 5;
            label1.Text = "Estudiantes";
            // 
            // estudianteGridView
            // 
            estudianteGridView.AllowUserToAddRows = false;
            estudianteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            estudianteGridView.BackgroundColor = Color.FromArgb(189, 224, 254);
            estudianteGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudianteGridView.Location = new Point(40, 85);
            estudianteGridView.Name = "estudianteGridView";
            estudianteGridView.RowHeadersVisible = false;
            estudianteGridView.RowHeadersWidth = 51;
            estudianteGridView.Size = new Size(702, 511);
            estudianteGridView.TabIndex = 7;
            estudianteGridView.CellContentClick += estudianteGridView_CellContentClick;
            // 
            // TomarAsistencia
            // 
            TomarAsistencia.BackColor = Color.FromArgb(189, 224, 254);
            TomarAsistencia.FlatStyle = FlatStyle.Popup;
            TomarAsistencia.Location = new Point(748, 48);
            TomarAsistencia.Name = "TomarAsistencia";
            TomarAsistencia.Size = new Size(142, 91);
            TomarAsistencia.TabIndex = 8;
            TomarAsistencia.Text = "Tomar Asistencia";
            TomarAsistencia.UseVisualStyleBackColor = false;
            TomarAsistencia.Click += TomarAsistencia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(189, 224, 254);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(305, 48);
            label3.Name = "label3";
            label3.Padding = new Padding(8, 0, 6, 0);
            label3.Size = new Size(135, 34);
            label3.TabIndex = 9;
            label3.Text = "Ausencias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(189, 224, 254);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(437, 48);
            label4.Name = "label4";
            label4.Padding = new Padding(22, 0, 22, 0);
            label4.Size = new Size(132, 34);
            label4.TabIndex = 10;
            label4.Text = "Tardías";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(189, 224, 254);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(570, 48);
            label5.Name = "label5";
            label5.Padding = new Padding(22, 0, 22, 0);
            label5.Size = new Size(172, 34);
            label5.TabIndex = 11;
            label5.Text = "Justificado";
            // 
            // btn_justificar
            // 
            btn_justificar.Location = new Point(768, 166);
            btn_justificar.Name = "btn_justificar";
            btn_justificar.Size = new Size(112, 84);
            btn_justificar.TabIndex = 12;
            btn_justificar.Text = "justificar";
            btn_justificar.UseVisualStyleBackColor = true;
            btn_justificar.Click += btn_justificar_Click;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(793, 304);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(94, 29);
            btn_volver.TabIndex = 13;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 210, 255);
            ClientSize = new Size(914, 600);
            Controls.Add(btn_volver);
            Controls.Add(btn_justificar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TomarAsistencia);
            Controls.Add(estudianteGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Alumnos";
            Text = "Alumnos";
            Load += Alumnos_Load;
            ((System.ComponentModel.ISupportInitialize)estudianteGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView estudianteGridView;
        private Button TomarAsistencia;
        private Label label3;
        private Label label4;
        public Label label2;
        private Label label5;
        private Button btn_justificar;
        private Button btn_volver;
    }
}