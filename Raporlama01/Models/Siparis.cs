//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raporlama01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparis
    {
        public int SiparisNo { get; set; }
        public string SiparisTarihi { get; set; }
        public string Aciklama { get; set; }
        public string TeslimAdresi { get; set; }
        public System.DateTime TeslimTarihi { get; set; }
        public int MusteriNo { get; set; }
        public int UrunNo { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }
    }
}