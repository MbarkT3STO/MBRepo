//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBRepo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public string PRD { get; set; }
        public Nullable<int> QTE { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}
