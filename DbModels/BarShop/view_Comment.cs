using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_Comment
{
    public int CMT_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }

    public int CARD_SEQ { get; set; }

    public byte? score { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? card_cate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? card_img_xs { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string comm_div { get; set; } = null!;
}
