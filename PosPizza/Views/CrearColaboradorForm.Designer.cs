namespace PosPizza.Views
{
    partial class CrearColaboradorForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtIdRol;
        private TextBox txtNombres;
        private TextBox txtDni;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private CheckBox chkEstado;
        private Button btnGuardar;

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
            this.txtIdRol = new TextBox();
            this.txtNombres = new TextBox();
            this.txtDni = new TextBox();
            this.txtCorreo = new TextBox();
            this.txtTelefono = new TextBox();
            this.txtUsuario = new TextBox();
            this.txtClave = new TextBox();
            this.chkEstado = new CheckBox();
            this.btnGuardar = new Button();

            this.SuspendLayout();

            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new Point(20, 20);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new Size(200, 23);
            this.txtIdRol.TabIndex = 0;
            this.txtIdRol.PlaceholderText = "ID Rol";

            // 
            // txtNombres
            // 
            this.txtNombres.Location = new Point(20, 60);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new Size(200, 23);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.PlaceholderText = "Nombres";

            // 
            // txtDni
            // 
            this.txtDni.Location = new Point(20, 100);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new Size(200, 23);
            this.txtDni.TabIndex = 2;
            this.txtDni.PlaceholderText = "DNI";

            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new Point(20, 140);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new Size(200, 23);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.PlaceholderText = "Correo";

            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new Point(20, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new Size(200, 23);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.PlaceholderText = "Teléfono";

            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new Point(20, 220);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new Size(200, 23);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.PlaceholderText = "Usuario";

            // 
            // txtClave
            // 
            this.txtClave.Location = new Point(20, 260);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new Size(200, 23);
            this.txtClave.TabIndex = 6;
            this.txtClave.PlaceholderText = "Clave";

            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new Point(20, 300);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new Size(61, 19);
            this.chkEstado.TabIndex = 7;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;

            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new Point(20, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(200, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);

            // 
            // CrearColaboradorForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(250, 400);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CrearColaboradorForm";
            this.Text = "Crear Colaborador";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}