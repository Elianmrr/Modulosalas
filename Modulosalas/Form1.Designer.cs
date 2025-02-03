namespace Modulosalas
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

         
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreSala = new TextBox();
            txtCapacidadMax = new TextBox();
            txtDescripcion = new TextBox();
            dataGridSalas = new DataGridView();
            btnAgregarSala = new Button();
            btnActualizarSala = new Button();
            btnEliminarSala = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSalas).BeginInit();
            SuspendLayout();
            // 
            // txtNombreSala
            // 
            txtNombreSala.Location = new Point(74, 66);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(125, 27);
            txtNombreSala.TabIndex = 0;
            // 
            // txtCapacidadMax
            // 
            txtCapacidadMax.Location = new Point(294, 66);
            txtCapacidadMax.Name = "txtCapacidadMax";
            txtCapacidadMax.Size = new Size(125, 27);
            txtCapacidadMax.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(521, 66);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // dataGridSalas
            // 
            dataGridSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSalas.Location = new Point(74, 137);
            dataGridSalas.Name = "dataGridSalas";
            dataGridSalas.RowHeadersWidth = 51;
            dataGridSalas.Size = new Size(467, 271);
            dataGridSalas.TabIndex = 3;
            // 
            // btnAgregarSala
            // 
            btnAgregarSala.Location = new Point(624, 194);
            btnAgregarSala.Name = "btnAgregarSala";
            btnAgregarSala.Size = new Size(94, 29);
            btnAgregarSala.TabIndex = 4;
            btnAgregarSala.Text = "AGREGAR SALAS";
            btnAgregarSala.UseVisualStyleBackColor = true;
            btnAgregarSala.Click += btnAgregarSala_Click;
            // 
            // btnActualizarSala
            // 
            btnActualizarSala.Location = new Point(624, 263);
            btnActualizarSala.Name = "btnActualizarSala";
            btnActualizarSala.Size = new Size(107, 29);
            btnActualizarSala.TabIndex = 5;
            btnActualizarSala.Text = "ACTUALIZAR SALA";
            btnActualizarSala.UseVisualStyleBackColor = true;
            btnActualizarSala.Click += btnActualizarSala_Click;
            // 
            // btnEliminarSala
            // 
            btnEliminarSala.Location = new Point(624, 334);
            btnEliminarSala.Name = "btnEliminarSala";
            btnEliminarSala.Size = new Size(94, 29);
            btnEliminarSala.TabIndex = 6;
            btnEliminarSala.Text = "ELIMINAR SALA";
            btnEliminarSala.UseVisualStyleBackColor = true;
            btnEliminarSala.Click += btnEliminarSala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarSala);
            Controls.Add(btnActualizarSala);
            Controls.Add(btnAgregarSala);
            Controls.Add(dataGridSalas);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCapacidadMax);
            Controls.Add(txtNombreSala);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreSala;
        private TextBox txtCapacidadMax;
        private TextBox txtDescripcion;
        private DataGridView dataGridSalas;
        private Button btnAgregarSala;
        private Button btnActualizarSala;
        private Button btnEliminarSala;
    }
}
