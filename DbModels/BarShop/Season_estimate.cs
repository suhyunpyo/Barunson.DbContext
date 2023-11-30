using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Season_estimate
{
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// E:완제품카드, P:주문카드, D:맞춤제작
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string osheet_div { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? com_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? com_place { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? com_address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string charge_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? charge_position { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string charge_email { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string phone { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? phone_extension { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;

    /// <summary>
    /// N:연하장, C:크리스마스
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string card_div { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int order_count { get; set; }

    /// <summary>
    /// N:안함, C:속지만, E:봉투만, A:모두
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? color_opt { get; set; }

    /// <summary>
    /// 0:신청안함, 1:신청함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isinpaper { get; set; } = null!;

    /// <summary>
    /// 0:신청안함, 1:신청함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ishandmade { get; set; } = null!;

    /// <summary>
    /// 0:신청안함, 1:신청함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isenvinsert { get; set; } = null!;

    /// <summary>
    /// 0:신청안함, 1:신청함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isembo { get; set; } = null!;

    /// <summary>
    /// 0:신청안함, 1:신청함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isprintadd { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? etc_message { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? upload_file { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string reply_yn { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
