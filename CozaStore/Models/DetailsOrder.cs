//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CozaStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailsOrder
    {
        public int Productid { get; set; }
        public int Orderid { get; set; }
        public Nullable<int> Sizeid { get; set; }
        public Nullable<int> Colorid { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}
