using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SEASON_MEMBER
{
    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string pwd { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string umail { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string? jumin { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string address { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string addr_detail { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string chk_sms { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string chk_mailservice { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string site_div { get; set; } = null!;

    public int? company_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? out_yorn { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? out_date { get; set; }
}
