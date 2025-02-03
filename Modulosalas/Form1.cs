using Modulosalas.Controlador;
using Modulosalas.Modulo;
using System.Data;

namespace Modulosalas
{
    public partial class Form1 : Form
    {
        private SalaController controller;

        public Form1()
        {
            InitializeComponent();
        }

        
        public void SetController(SalaController controller)
        {
            this.controller = controller;
        }

       
        public void MostrarSalas(List<Sala> salas)
        {
            dataGridSalas.DataSource = salas;
        }

       
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }




        private void btnAgregarSala_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala
            {
                NombreSala = txtNombreSala.Text,
                CapacidadMax = int.Parse(txtCapacidadMax.Text),
                Descripcion = txtDescripcion.Text
            };
            controller.AgregarSala(sala);
        }

       
        private void btnActualizarSala_Click(object sender, EventArgs e)
        {
            if (dataGridSalas.SelectedRows.Count > 0)
            {
                int idSala = int.Parse(dataGridSalas.SelectedRows[0].Cells[0].Value.ToString());
                Sala sala = new Sala
                {
                    ID = idSala,
                    NombreSala = txtNombreSala.Text,
                    CapacidadMax = int.Parse(txtCapacidadMax.Text),
                    Descripcion = txtDescripcion.Text
                };
                controller.ActualizarSala(sala);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una sala.");
            }
        }

        
        private void btnEliminarSala_Click(object sender, EventArgs e)
        {
            if (dataGridSalas.SelectedRows.Count > 0)
            {
                int idSala = int.Parse(dataGridSalas.SelectedRows[0].Cells[0].Value.ToString());
                controller.EliminarSala(idSala);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una sala.");
            }

        }
    }
}
