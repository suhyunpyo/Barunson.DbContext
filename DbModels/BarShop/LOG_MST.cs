using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 로그파일
/// </summary>
public partial class LOG_MST
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? GUID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SITE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LOCATION { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SUB_LOCATION { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LOG_TYPE_NAME { get; set; }

    [StringLength(4000)]
    public string? MSG { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
