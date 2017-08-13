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
    
    public partial class T_PAGOS
    {
        public T_PAGOS()
        {
            this.T_UNION_PAGO_OTRO_CARGO = new HashSet<T_UNION_PAGO_OTRO_CARGO>();
            this.T_UNION_PAGO_LECTURA_MEDIDOR = new HashSet<T_UNION_PAGO_LECTURA_MEDIDOR>();
        }
    
        public long ID_PAGO { get; set; }
        public long ID_EMPLEADO_CAJA { get; set; }
        public System.DateTime FECHA_PAGO { get; set; }
        public long ID_EMPLEADO_AUTORIZA_DESCUENTO { get; set; }
        public long ID_METODO_PAGO { get; set; }
        public long ID_INSTITUCION_BANCARIA { get; set; }
        public string NUMERO_CUENTA { get; set; }
        public string FOLIO_AUTORIZACION { get; set; }
        public System.DateTime FECHA_ALTA_REGISTRO { get; set; }
        public System.DateTime FACHA_MODIFICACION_REGISTRO { get; set; }
    
        public virtual CT_INSTITUCIONES_BANCARIAS CT_INSTITUCIONES_BANCARIAS { get; set; }
        public virtual CT_METODOS_DE_PAGO CT_METODOS_DE_PAGO { get; set; }
        public virtual T_EMPLEADOS T_EMPLEADOS { get; set; }
        public virtual T_EMPLEADOS T_EMPLEADOS1 { get; set; }
        public virtual ICollection<T_UNION_PAGO_OTRO_CARGO> T_UNION_PAGO_OTRO_CARGO { get; set; }
        public virtual ICollection<T_UNION_PAGO_LECTURA_MEDIDOR> T_UNION_PAGO_LECTURA_MEDIDOR { get; set; }
    }
}