using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Talla
    {

        private int idTalla;
        private int idZapato;
        private string tallaZapato;
        private int cantidad;

        public int IdTalla { get => idTalla; set => idTalla = value; }
        public int IdZapato { get => idZapato; set => idZapato = value; }
        public string TallaZapato { get => tallaZapato; set => tallaZapato = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }



    }
}
