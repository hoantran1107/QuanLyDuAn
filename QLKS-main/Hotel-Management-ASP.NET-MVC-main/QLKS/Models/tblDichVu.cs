
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QLKS.Models
{

using System;
    using System.Collections.Generic;
    
public partial class tblDichVu
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblDichVu()
    {

        this.tblDichVuDaDats = new HashSet<tblDichVuDaDat>();

    }


    public int ma_dv { get; set; }

    public string ten_dv { get; set; }

    public Nullable<double> gia { get; set; }

    public string don_vi { get; set; }

    public string anh { get; set; }

    public Nullable<int> ton_kho { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tblDichVuDaDat> tblDichVuDaDats { get; set; }

}

}