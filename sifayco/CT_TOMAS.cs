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
    
    public partial class CT_TOMAS
    {
        public CT_TOMAS()
        {
            this.T_CONTRATOS = new HashSet<T_CONTRATOS>();
        }
    
        public long ID_TIPO_TOMA { get; set; }
        public string GRUPO { get; set; }
        public string SGRUPO { get; set; }
        public string SSGRUPO { get; set; }
        public string DESCRIPCION { get; set; }
        public string UNIDAD { get; set; }
        public double CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double IMPORTE { get; set; }
    
        public virtual ICollection<T_CONTRATOS> T_CONTRATOS { get; set; }
    }
}