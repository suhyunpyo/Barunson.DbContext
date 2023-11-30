using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVT_GIFT_LIKE
{
    [Key]
    public int SEQ { get; set; }

    public int? GIFT_NUM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GIFT_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GUID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
