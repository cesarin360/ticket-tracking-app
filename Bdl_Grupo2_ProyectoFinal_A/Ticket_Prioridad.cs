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
    
    public partial class Ticket_Prioridad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket_Prioridad()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int TktPrd_Id { get; set; }
        public string TktPrd_Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
