using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int ID { set; get; }
        public int DNI { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public string Direccion { set; get; }
        public string Ciudad { set; get; }
        public int CP { set; get; }
    }
}
