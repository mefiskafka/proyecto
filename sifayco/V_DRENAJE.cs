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
    
    public partial class V_DRENAJE
    {
        public long ID_DRENAJE { get; set; }
        public long ID_EMPLEADO_CAPTURA { get; set; }
        public long ID_CONTRATO { get; set; }
        public System.DateTime FECHA_CAPTURA { get; set; }
        public double IMPORTE_DRENAJE { get; set; }
        public double PORCENTAJE_DESCUENTO { get; set; }
        public Nullable<double> IMPORTE_ANOMALIA_CON_DESCUENTO { get; set; }
        public double IMPORTE_DRENAJE_AJUSTADO { get; set; }
        public Nullable<double> IMPORTE_DRENAJE_FINAL { get; set; }
        public System.DateTime FECHA_ALTA_REGISTRO { get; set; }
        public System.DateTime FECHA_MODIFICACION_REGISTRO { get; set; }
    }
}