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
    
    public partial class Ubicacion_Usuarios
    {
        public int UbcUsr_Id { get; set; }
        public double UbcUsr_Longitud { get; set; }
        public double UbcUsr_Latitud { get; set; }
        public Nullable<int> Usr_Id { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}