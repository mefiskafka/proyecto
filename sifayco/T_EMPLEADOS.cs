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
    
    public partial class T_EMPLEADOS
    {
        public T_EMPLEADOS()
        {
            this.T_DRENAJE = new HashSet<T_DRENAJE>();
            this.T_OTROS_CARGOS = new HashSet<T_OTROS_CARGOS>();
            this.T_OTROS_CARGOS1 = new HashSet<T_OTROS_CARGOS>();
            this.T_LECTURAS_MEDIDOR = new HashSet<T_LECTURAS_MEDIDOR>();
            this.T_LECTURAS_MEDIDOR1 = new HashSet<T_LECTURAS_MEDIDOR>();
            this.T_PAGOS = new HashSet<T_PAGOS>();
            this.T_PAGOS1 = new HashSet<T_PAGOS>();
        }
    
        public long ID_EMPLEADO { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
    
        public virtual ICollection<T_DRENAJE> T_DRENAJE { get; set; }
        public virtual ICollection<T_OTROS_CARGOS> T_OTROS_CARGOS { get; set; }
        public virtual ICollection<T_OTROS_CARGOS> T_OTROS_CARGOS1 { get; set; }
        public virtual ICollection<T_LECTURAS_MEDIDOR> T_LECTURAS_MEDIDOR { get; set; }
        public virtual ICollection<T_LECTURAS_MEDIDOR> T_LECTURAS_MEDIDOR1 { get; set; }
        public virtual ICollection<T_PAGOS> T_PAGOS { get; set; }
        public virtual ICollection<T_PAGOS> T_PAGOS1 { get; set; }
    }
}
