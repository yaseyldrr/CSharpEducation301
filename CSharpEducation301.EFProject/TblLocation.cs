//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEducation301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblLocation
    {
        public int LocationId { get; set; }
        public string LocationCity { get; set; }
        public string LocationCountry { get; set; }
        public Nullable<decimal> LocationCapacity { get; set; }
        public string LocationPrice { get; set; }
        public string DayNight { get; set; }
        public Nullable<int> GuideId { get; set; }
    
        public virtual TblGuide TblGuide { get; set; }
    }
}
