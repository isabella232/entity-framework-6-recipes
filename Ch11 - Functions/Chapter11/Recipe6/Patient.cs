//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunctionsEFRecipe6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.PatientVisits = new HashSet<PatientVisit>();
        }
    
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    
        public virtual ICollection<PatientVisit> PatientVisits { get; set; }
    }
}
