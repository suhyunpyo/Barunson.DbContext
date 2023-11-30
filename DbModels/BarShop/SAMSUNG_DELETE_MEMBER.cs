using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 삼성전자동의 취소 데이터
/// </summary>
[PrimaryKey("CONNINFO", "UID")]
public partial class SAMSUNG_DELETE_MEMBER
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string CONNINFO { get; set; } = null!;

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? UNAME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_SAMSUNG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_MARKETING { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELETE_DATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? DELETE_UID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_LG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_CUCKOO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_CASAMIA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_KT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_HYUNDAI { get; set; }
}
