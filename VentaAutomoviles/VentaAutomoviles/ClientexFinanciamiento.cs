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
    
    public partial class ClientexFinanciamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientexFinanciamiento()
        {
            this.PagoxClientexFinanciamientoes = new HashSet<PagoxClientexFinanciamiento>();
        }
    
        public int idClientexFinanciamiento { get; set; }
        public int idFinanciamiento { get; set; }
    
        public virtual Financiamiento Financiamiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoxClientexFinanciamiento> PagoxClientexFinanciamientoes { get; set; }
    }
}
