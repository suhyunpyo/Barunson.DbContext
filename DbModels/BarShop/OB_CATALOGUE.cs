using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class OB_CATALOGUE
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(200)]
    public string? FILE_NAME { get; set; }

    [StringLength(1000)]
    public string? FILE_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
