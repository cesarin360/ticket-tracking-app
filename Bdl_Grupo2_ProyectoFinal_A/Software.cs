//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bdl_Grupo2_ProyectoFinal_A
{
    using System;
    using System.Collections.Generic;
    
    public partial class Software
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Software()
        {
            this.Equipos = new HashSet<Equipos>();
        }
    
        public int Sfw_Id { get; set; }
        public string Sfw_Nombre { get; set; }
        public Nullable<int> Fabric_Id { get; set; }
        public Nullable<int> TpStw_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual Tipo_Software Tipo_Software { get; set; }
    }
}
