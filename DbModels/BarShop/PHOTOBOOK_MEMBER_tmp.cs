using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class PHOTOBOOK_MEMBER_tmp
{
    public int id { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? birth { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? rdate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? hand_phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? addressCHK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? phoneCHK { get; set; }
}
