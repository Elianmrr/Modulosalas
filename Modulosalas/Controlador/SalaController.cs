using Modulosalas.Modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulosalas.Controlador
{
    public class SalaController
    {
        private SalaService salaService;
        private Form1 vista;

        public SalaController(Form1 vista)
        {
            this.salaService = new SalaService();
            this.vista = vista;
            vista.SetController(this);
        }

        public void CargarSalas()
        {
            var salas = salaService.ObtenerSalas();
            vista.MostrarSalas(salas);
        }

        public void AgregarSala(Sala sala)
        {
            salaService.AgregarSala(sala);
            vista.MostrarMensaje("Sala agregada exitosamente.");
            CargarSalas();
        }

        public void ActualizarSala(Sala sala)
        {
            salaService.ActualizarSala(sala);
            vista.MostrarMensaje("Sala actualizada exitosamente.");
            CargarSalas();
        }

        public void EliminarSala(int id)
        {
            salaService.EliminarSala(id);
            vista.MostrarMensaje("Sala eliminada exitosamente.");
            CargarSalas();
        }
    }
}
