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
    
    public partial class Tecnicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tecnicos()
        {
            this.Tickets = new HashSet<Tickets>();
            this.UsrTecnicos = new HashSet<UsrTecnicos>();
        }
    
        public int Tec_Id { get; set; }
        public string DPI { get; set; }
        public string Tec_Nombre1 { get; set; }
        public string Tec_Nombre2 { get; set; }
        public string Tec_Nombre3 { get; set; }
        public string Tec_Apellido1 { get; set; }
        public string Tec_Apellido2 { get; set; }
        public string Tec_Apellido3 { get; set; }
        public string Tec_Direccion { get; set; }
        public string Tec_TlfPersonal { get; set; }
        public string Tec_TlfCasa { get; set; }
        public Nullable<int> Prf_Id { get; set; }
        public int aceptado { get; set; }
        public int Cant_TicketAsignados { get; set; }
        public virtual Perfiles Perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsrTecnicos> UsrTecnicos { get; set; }
    }
}
