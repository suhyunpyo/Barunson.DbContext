using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드)카드질문
/// </summary>
public partial class S4_Card_Talk
{
    [Key]
    public int seq { get; set; }

    public int tk_seq { get; set; }

    public byte tk_ansnum { get; set; }

    public int company_seq { get; set; }

    public int card_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

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
    public string? chk_send_sms { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_send_mail { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? order_seq { get; set; }
}
