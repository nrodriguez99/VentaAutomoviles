//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaAutomoviles
{
    using System;
    using System.Collections.Generic;
    
    public partial class FotoxAutomovil
    {
        public int idFotoxAutomovil { get; set; }
        public int idFoto { get; set; }
        public int idAutomovil { get; set; }
    
        public virtual Automovil Automovil { get; set; }
        public virtual Foto Foto { get; set; }
    }
}
