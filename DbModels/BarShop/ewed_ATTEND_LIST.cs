using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_ATTEND_LIST
{
    [Key]
    public int seq { get; set; }

    public int buy_card_SEQ { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string buy_card_UID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string rname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string rmail { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? result { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rdate { get; set; }
}
