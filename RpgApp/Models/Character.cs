//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RpgApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public int Lvl { get; set; }
        public int Race { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
    
        public virtual Gender Gender1 { get; set; }
        public virtual Race Race1 { get; set; }
    }
}