using System;
using System.Windows.Forms;
using PosPizza.Controllers;
using PosPizza.Models;

namespace PosPizza.Views
{
    public partial class CrearColaboradorForm : Form
    {
        private readonly AuthService _authService;
        private readonly Colaborador _colaborador;

        public CrearColaboradorForm(AuthService authService, Colaborador colaborador = null)
        {
            InitializeComponent();
            _authService = authService;
            _colaborador = colaborador;

            if (_colaborador != null)
            {
                txtIdRol.Text = _colaborador.IdRol.ToString();
                txtNombres.Text = _colaborador.Nombres;
                txtDni.Text = _colaborador.Dni;
                txtCorreo.Text = _colaborador.Correo;
                txtTelefono.Text = _colaborador.Telefono;
                txtUsuario.Text = _colaborador.Usuario;
                txtClave.Text = _colaborador.Clave;
                chkEstado.Checked = _colaborador.Estado;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var colaborador = new Colaborador
            {
                IdRol = int.Parse(txtIdRol.Text),
                Nombres = txtNombres.Text,
                Dni = txtDni.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Usuario = txtUsuario.Text,
                Clave = txtClave.Text,
                Estado = chkEstado.Checked
            };

            try
            {
                bool result;
                if (_colaborador == null)
                {
                    result = await _authService.CrearColaborador(colaborador);
                }
                else
                {
                    colaborador.Id = _colaborador.Id;
                    result = await _authService.ActualizarColaborador(colaborador);
                }

                if (result)
                {
                    MessageBox.Show("Colaborador guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}