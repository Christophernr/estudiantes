namespace formualarios
{
    partial class Asistencia
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
            btnGuardar = new Button();
            AlumnosGridView = new DataGridView();
            btn_volver = new Button();
            ((System.ComponentModel.ISupportInitialize)AlumnosGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 63);
            label2.Name = "label2";
            label2.Size = new Size(122, 34);
            label2.TabIndex = 11;
            label2.Text = "Asistencia";
            //label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 63);
            label1.Name = "label1";
            label1.Padding = new Padding(17, 0, 17, 0);
            label1.Size = new Size(234, 34);
            label1.TabIndex = 10;
            label1.Text = "Estudiantes";
            //label1.Click += label1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(189, 224, 254);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(689, 51);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(187, 31);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AlumnosGridView
            // 
            AlumnosGridView.AllowUserToAddRows = false;
            AlumnosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AlumnosGridView.BackgroundColor = Color.FromArgb(189, 224, 254);
            AlumnosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlumnosGridView.Location = new Point(31, 100);
            AlumnosGridView.Name = "AlumnosGridView";
            AlumnosGridView.RowHeadersVisible = false;
            AlumnosGridView.RowHeadersWidth = 51;
            AlumnosGridView.Size = new Size(355, 459);
            AlumnosGridView.TabIndex = 14;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(732, 126);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(94, 29);
            btn_volver.TabIndex = 15;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(162, 210, 255);
            ClientSize = new Size(914, 600);
            Controls.Add(btn_volver);
            Controls.Add(AlumnosGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Asistencia";
            Text = "Asistencia";
            Load += Asistencia_Load;
            ((System.ComponentModel.ISupportInitialize)AlumnosGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private DataGridView AlumnosGridView;
        private Button btn_volver;
    }
}