using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_SAMSUNG
{
    [Key]
    public int id { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? branch_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string c_name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? c_phone { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? c_email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? coupon_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAns { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? c_sex { get; set; }

    public byte? c_age { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedding_Date { get; set; }

    public byte? ans1 { get; set; }

    public byte? ans2 { get; set; }

    public byte? ans3 { get; set; }

    public byte? ans4 { get; set; }

    public byte? ans5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ans5_detail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sreg_Date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ans_date { get; set; }

    public int? l_info1 { get; set; }

    public int? l_info2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? admin_memo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBarunson { get; set; }
}
