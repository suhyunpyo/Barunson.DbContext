using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// Old 유저 코멘트
/// </summary>
[PrimaryKey("CARD_SEQ", "CMT_SEQ")]
public partial class CARD_USER_COMMNET
{
    [Key]
    public int CMT_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sales_Gubun { get; set; }

    public int? company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_UID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? COMMENT { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? SERVICE_MENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }

    [Key]
    public int CARD_SEQ { get; set; }

    public byte? score { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DIV { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WEDD_DT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WEDD_PLACE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TRAVEL_PLACE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? tmp_data { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsBest { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string IsDP { get; set; } = null!;
}
