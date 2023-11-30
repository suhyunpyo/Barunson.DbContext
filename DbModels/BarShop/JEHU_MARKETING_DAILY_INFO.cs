using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class JEHU_MARKETING_DAILY_INFO
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BDAY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Hphone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZIP { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? regdate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? reg_time { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ConnInfo { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? muid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? site { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Birth { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? insert_date { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? wedd_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_day { get; set; }
}
