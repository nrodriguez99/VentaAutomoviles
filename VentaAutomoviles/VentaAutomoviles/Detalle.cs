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
    
    public partial class Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detalle()
        {
            this.DetallexFacturas = new HashSet<DetallexFactura>();
        }
    
        public int idDetalle { get; set; }
        public int idAutxSucVentxCli { get; set; }
        public string descripcion { get; set; }
    
        public virtual AutxSucxVentxCli AutxSucxVentxCli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallexFactura> DetallexFacturas { get; set; }
    }
}
