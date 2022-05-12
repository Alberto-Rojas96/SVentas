using System;
using System.Collections.Generic;

namespace WSVenta.Models
{
    public partial class Venta
    {
        public long Id { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Concepto IdNavigation { get; set; }
    }
}
