//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVGS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int RatingID { get; set; }
        public double Rating1 { get; set; }
        public int MemberID { get; set; }
        public int GameID { get; set; }
        public Nullable<System.DateTime> RatingDate { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}