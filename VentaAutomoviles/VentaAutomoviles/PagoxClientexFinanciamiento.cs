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
    
    public partial class PagoxClientexFinanciamiento
    {
        public int idPagoxClientexFinanciamiento { get; set; }
        public int idPago { get; set; }
        public int idClientexFinanciamiento { get; set; }
    
        public virtual ClientexFinanciamiento ClientexFinanciamiento { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
