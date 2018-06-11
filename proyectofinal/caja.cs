using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    class caja
    {
        string nombreproduc;
        string categoria;
        string cantidad;
        string precio;
        string subTotal;
        string total;

        public string Nombreproduc { get => nombreproduc; set => nombreproduc = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Precio { get => precio; set => precio = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string Total { get => total; set => total = value; }
    }
}
