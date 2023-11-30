using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CopperPlateExclude
{
    [Key]
    public int card_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }
}
