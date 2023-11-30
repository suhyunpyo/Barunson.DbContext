using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("uid", "sales_gubun")]
public partial class THE_MEMBER_OUT
{
    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int? company_seq { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone3 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? email { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans4 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans6 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans7 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ans_detail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? reg_date { get; set; }
}
