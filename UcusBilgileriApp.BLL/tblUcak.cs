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
    
    public partial class tblUcak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUcak()
        {
            this.tblUcusBilgileris = new HashSet<tblUcusBilgileri>();
        }
    
        public string Id_Ucak { get; set; }
        public string Ucak_Adi { get; set; }
        public int Yolcu_Sayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUcusBilgileri> tblUcusBilgileris { get; set; }
    }
}
