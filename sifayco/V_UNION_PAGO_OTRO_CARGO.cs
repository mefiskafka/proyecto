//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sifayco
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_UNION_PAGO_OTRO_CARGO
    {
        public long ID_OTRO_CARGO { get; set; }
        public long ID_CONTRATO { get; set; }
        public System.DateTime FECHA_CAPTURA { get; set; }
        public long ID_EMPLEADO_REPORTA { get; set; }
        public long ID_EMPLEADO_CAPTURA { get; set; }
        public double IMPORTE_OTRO_CARGO { get; set; }
        public double PORCENTAJE_DESCUENTO { get; set; }
        public Nullable<double> IMPORTE_OTRO_CARGO_CON_DESCUENTO { get; set; }
        public double IMPORTE_OTRO_CARGO_AJUSTADO { get; set; }
        public Nullable<double> IMPORTE_OTRO_CARGO_FINAL { get; set; }
        public Nullable<long> ID_PAGO { get; set; }
        public Nullable<double> IMPORTE_PAGADO { get; set; }
        public Nullable<double> IMPORTE_PENDIENTE { get; set; }
        public Nullable<double> IMPORTE_AFAVOR { get; set; }
    }
}