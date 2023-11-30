using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Branch_Member
{
    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string pw { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? mail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_mailservice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sex { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? jumin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? birth { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_event { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_penpal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rdate { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? addressCHK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? phoneCHK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nickname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? inpath { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_ad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? login_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? login_date_latest { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? job { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? site_div { get; set; }

    public short? company_seq { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? sample_chk { get; set; }
}
