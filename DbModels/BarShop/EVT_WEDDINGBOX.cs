using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVT_WEDDINGBOX
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
