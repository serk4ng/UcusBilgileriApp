//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UcusBilgileriApp.BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblYolcular
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ucus_Numarasi { get; set; }
    
        public virtual tblUcusBilgileri tblUcusBilgileri { get; set; }
    }
}
