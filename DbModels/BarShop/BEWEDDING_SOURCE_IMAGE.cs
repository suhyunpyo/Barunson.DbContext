using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BEWEDDING_SOURCE_IMAGE
{
    [Key]
    public int SOURCE_IMG_SEQ { get; set; }

    public int SOURCE_SEQ { get; set; }

    [StringLength(50)]
    public string LOGO_TYPE { get; set; } = null!;

    [StringLength(2000)]
    public string LOGO_IMG_URL { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(100)]
    public string? UPD_ID { get; set; }
}
