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
    
    public partial class CT_METODOS_DE_PAGO
    {
        public CT_METODOS_DE_PAGO()
        {
            this.T_PAGOS = new HashSet<T_PAGOS>();
        }
    
        public long ID_METODO_PAGO { get; set; }
        public string CLAVE { get; set; }
        public string DESCRIPCION { get; set; }
        public bool HABILITADO { get; set; }
    
        public virtual ICollection<T_PAGOS> T_PAGOS { get; set; }
    }
}
