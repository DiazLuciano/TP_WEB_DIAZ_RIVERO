using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public long ID { set; get; }
        public string DNI { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public string Direccion { set; get; }
        public string Ciudad { set; get; }
        public string CP { set; get; }
    }
}
