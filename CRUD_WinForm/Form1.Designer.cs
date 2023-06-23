namespace CRUD_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            btnProductos = new Button();
            btnProductosVendidos = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnIniciarSesion = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(35, 25);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(589, 329);
            dataGridView.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(630, 38);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(158, 23);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.Location = new Point(630, 67);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(158, 23);
            btnProductosVendidos.TabIndex = 2;
            btnProductosVendidos.Text = "Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(630, 96);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(158, 23);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(630, 125);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(158, 23);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(292, 412);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(104, 26);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(236, 377);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(102, 23);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(344, 377);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(101, 23);
            txtContrasena.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 359);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 359);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Clave";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnVentas);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnProductos);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnProductos;
        private Button btnProductosVendidos;
        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnIniciarSesion;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
    }
}