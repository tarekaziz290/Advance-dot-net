//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plan
    {
        public Plan()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Credits { get; set; }
        public int Templates { get; set; }
        public int ApiKeys { get; set; }
        public int Contacts { get; set; }
    
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
