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
    
    public partial class V_LECTURAS_MEDIDOR
    {
        public long ID_LECTURA_MEDIDOR { get; set; }
        public long ID_CONTRATO { get; set; }
        public System.DateTime FECHA_LECTURA_SITIO { get; set; }
        public long ID_EMPLEADO_CAPTURA { get; set; }
        public long ID_EMPLEADO_LECTURISTA { get; set; }
        public int ES_TARIFA { get; set; }
        public double LECTURA_MEDIDOR_m3 { get; set; }
        public double CONSUMO_m3 { get; set; }
        public double COSTO_METRO_CUBICO { get; set; }
        public double IMPORTE_CONSUMO { get; set; }
        public double PORCENTAJE_DESCUENTO { get; set; }
        public Nullable<double> IMPORTE_CONSUMO_CON_DESCUENTO { get; set; }
        public double IMPORTE_CONSUMO_AJUSTADO { get; set; }
        public Nullable<double> IMPORTE_CONSUMO_FINAL { get; set; }
        public System.DateTime FECHA_ALTA_REGISTRO { get; set; }
        public System.DateTime FECHA_MODIFICACION_REGISTRO { get; set; }
    }
}
