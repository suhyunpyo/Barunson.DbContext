using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class AUTO_CHOAN_APP_STATUS_LOG
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string MACHINE_IP { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? APP_NAME { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string APP_STATUS { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
