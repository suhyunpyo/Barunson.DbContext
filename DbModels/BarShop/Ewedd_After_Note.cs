using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CMT_SEQ", "CARD_SEQ")]
public partial class Ewedd_After_Note
{
    [Key]
    public int CMT_SEQ { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? MEMBER_UID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? COMMENT { get; set; }

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
    public string TITLE { get; set; } = null!;
}
