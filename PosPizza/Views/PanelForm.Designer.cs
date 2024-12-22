namespace PosPizza.Views
{
    partial class PanelForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnInfoCategoria;
        private Button btnCrearProveedor;
        private Button btnCrearColaborador;
        private DataGridView dgvColaboradores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInfoCategoria = new Button();
            this.btnCrearProveedor = new Button();
            this.btnCrearColaborador = new Button();
            this.dgvColaboradores = new DataGridView();

            this.SuspendLayout();

            // 
            // btnInfoCategoria
            // 
            this.btnInfoCategoria.Location = new Point(10, 10);
            this.btnInfoCategoria.Name = "btnInfoCategoria";
            this.btnInfoCategoria.Size = new Size(120, 30);
            this.btnInfoCategoria.TabIndex = 0;
            this.btnInfoCategoria.Text = "Info. Categoría";
            this.btnInfoCategoria.UseVisualStyleBackColor = true;
            this.btnInfoCategoria.Click += new EventHandler(this.btnInfoCategoria_Click);

            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.Location = new Point(140, 10);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new Size(120, 30);
            this.btnCrearProveedor.TabIndex = 1;
            this.btnCrearProveedor.Text = "Crear Proveedor";
            this.btnCrearProveedor.UseVisualStyleBackColor = true;

            // 
            // btnCrearColaborador
            // 
            this.btnCrearColaborador.Location = new Point(270, 10);
            this.btnCrearColaborador.Name = "btnCrearColaborador";
            this.btnCrearColaborador.Size = new Size(130, 30);
            this.btnCrearColaborador.TabIndex = 2;
            this.btnCrearColaborador.Text = "Crear Colaborador";
            this.btnCrearColaborador.UseVisualStyleBackColor = true;
            this.btnCrearColaborador.Click += new EventHandler(this.btnCrearColaborador_Click);

            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Location = new Point(10, 50);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.Size = new Size(760, 380);
            this.dgvColaboradores.TabIndex = 3;
            this.dgvColaboradores.CellClick += new DataGridViewCellEventHandler(this.dgvColaboradores_CellClick);

            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.btnInfoCategoria);
            this.Controls.Add(this.btnCrearProveedor);
            this.Controls.Add(this.btnCrearColaborador);
            this.Controls.Add(this.dgvColaboradores);
            this.Name = "PanelForm";
            this.Text = "Panel - POS Pizza";
            this.ResumeLayout(false);
        }
    }
}