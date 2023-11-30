using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BEWEDDING_SOURCE
{
    [Key]
    public int SOURCE_SEQ { get; set; }

    [StringLength(20)]
    public string? SOURCE_CODE { get; set; }

    [StringLength(100)]
    public string SOURCE_NAME { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(50)]
    public string? UPD_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string USE_YN { get; set; } = null!;
}
