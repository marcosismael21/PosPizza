using System;
using System.Windows.Forms;
using PosPizza.Controllers;
using PosPizza.Models;

namespace PosPizza.Views
{
    public partial class PanelForm : Form
    {
        private readonly AuthService _authService;

        public PanelForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            CargarColaboradores();
        }

        private async void CargarColaboradores()
        {
            try
            {
                var colaboradores = await _authService.ObtenerColaboradores();
                dgvColaboradores.DataSource = colaboradores;
                AgregarBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarBotones()
        {
            // Columna de Editar
            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Name = "btnEditar"
            };
            dgvColaboradores.Columns.Add(btnEditar);

            // Columna de Eliminar
            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "btnEliminar"
            };
            dgvColaboradores.Columns.Add(btnEliminar);
        }

        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvColaboradores.Columns["btnEditar"].Index)
                {
                    // Lógica para editar colaborador
                    var colaborador = (Colaborador)dgvColaboradores.Rows[e.RowIndex].DataBoundItem;
                    using (var form = new CrearColaboradorForm(_authService, colaborador))
                    {
                        form.ShowDialog();
                        CargarColaboradores(); // Recargar la tabla después de editar un colaborador
                    }
                }
                else if (e.ColumnIndex == dgvColaboradores.Columns["btnEliminar"].Index)
                {
                    // Lógica para eliminar colaborador
                    var colaborador = (Colaborador)dgvColaboradores.Rows[e.RowIndex].DataBoundItem;
                    EliminarColaborador(colaborador.Id);
                }
            }
        }

        private async void EliminarColaborador(int id)
        {
            try
            {
                var result = await _authService.EliminarColaborador(id);
                if (result)
                {
                    MessageBox.Show("Colaborador eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarColaboradores(); // Recargar la tabla después de eliminar un colaborador
                }
                else
                {
                    MessageBox.Show("Error al eliminar colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearColaborador_Click(object sender, EventArgs e)
        {
            using (var form = new CrearColaboradorForm(_authService))
            {
                form.ShowDialog();
                CargarColaboradores(); // Recargar la tabla después de crear un colaborador
            }
        }

        private void btnInfoCategoria_Click(object sender, EventArgs e)
        {
            /*using (var form = new CategoriaForm(_authService))
            {
                form.ShowDialog();
            }*/
        }
    }
}