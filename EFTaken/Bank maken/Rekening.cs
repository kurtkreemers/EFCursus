//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank_maken
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Rekening
    {
        public string RekeningNr { get; set; }
        public int KlantNr { get; set; }
        public decimal Saldo { get; set; }
    
        public virtual Klant Klant { get; set; }
    }
}
