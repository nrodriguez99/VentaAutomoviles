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
    
    public partial class VentasxCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VentasxCliente()
        {
            this.AutxSucxVentxClis = new HashSet<AutxSucxVentxCli>();
        }
    
        public int idVentaxCliente { get; set; }
        public int idVenta { get; set; }
        public int idCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutxSucxVentxCli> AutxSucxVentxClis { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
