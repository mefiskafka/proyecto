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
    
    public partial class CT_TIPOS_OTROS_CARGOS
    {
        public CT_TIPOS_OTROS_CARGOS()
        {
            this.T_OTROS_CARGOS = new HashSet<T_OTROS_CARGOS>();
        }
    
        public long ID_TIPO_OTRO_CARGO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<T_OTROS_CARGOS> T_OTROS_CARGOS { get; set; }
    }
}