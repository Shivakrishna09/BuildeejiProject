//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buildeeji.Models.BuildeejiDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyAvailability
    {
        public int PropertyAvailabilityID { get; set; }
        public string PropertyAvailability1 { get; set; }
        public string AvailabilityDesc { get; set; }
        public string LanguageCulture { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsArchived { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
