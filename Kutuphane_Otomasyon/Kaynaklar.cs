//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane_Otomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kaynaklar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kaynaklar()
        {
            this.Kayitlar = new HashSet<Kayitlar>();
        }
    
        public int Kaynak_iD { get; set; }
        public string Kaynak_Ad { get; set; }
        public string Kaynak_Tur { get; set; }
        public string Kaynak_Yazar { get; set; }
        public string Kaynak_Yayıncı { get; set; }
        public Nullable<System.DateTime> Kaynak_BasımTarihi { get; set; }
        public Nullable<int> Kaynak_SayfaSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayitlar> Kayitlar { get; set; }
    }
}
