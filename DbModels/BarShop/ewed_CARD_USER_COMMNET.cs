using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_CARD_USER_COMMNET
{
    [Key]
    public int CMT_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_UID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? COMMENT { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? SERVICE_MENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }

    public int CARD_SEQ { get; set; }

    public byte? score { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DIV { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsBest { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? site_div { get; set; }
}
