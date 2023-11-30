using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class lgdacom_cas_log
{
    [Key]
    public int seq { get; set; }

    [StringLength(200)]
    public string? hashdata { get; set; }

    [StringLength(10)]
    public string? casflag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }
}
