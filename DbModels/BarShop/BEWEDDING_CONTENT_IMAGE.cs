using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BEWEDDING_CONTENT_IMAGE
{
    [Key]
    public int IMG_SEQ { get; set; }

    public int CONTENT_SEQ { get; set; }

    [StringLength(50)]
    public string IMG_TYPE { get; set; } = null!;

    [StringLength(1000)]
    public string? IMG_URL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(50)]
    public string? UPD_ID { get; set; }
}
