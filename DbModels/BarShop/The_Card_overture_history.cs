using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Card_overture_history
{
    [Key]
    public int OVERTURE_ID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? REMOTE_ADDR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? REFER_SITE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CONNECT_TIME { get; set; }
}
