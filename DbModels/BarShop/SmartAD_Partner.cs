using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 광고업체
/// </summary>
public partial class SmartAD_Partner
{
    [Key]
    public int PARTNER_SEQ { get; set; }

    [StringLength(100)]
    public string PARTNER_ID { get; set; } = null!;

    [StringLength(25)]
    public string? PARTNER_NAME { get; set; }

    [StringLength(25)]
    public string? PARTNER_TELEPHONE { get; set; }

    [StringLength(25)]
    public string? PARTNER_CELLPHONE { get; set; }

    [StringLength(25)]
    public string? PARTNER_ADMIN_NAME { get; set; }

    [StringLength(100)]
    public string? PARTNER_ADMIN_POSITION { get; set; }

    [StringLength(100)]
    public string? PARTNER_ADMIN_DEPARTMENT { get; set; }

    [StringLength(100)]
    public string? PARTNER_EMAIL { get; set; }

    [StringLength(25)]
    public string PARTNER_PASSWORD { get; set; } = null!;

    [StringLength(200)]
    public string? PARTNER_HOMEPAGE { get; set; }

    [StringLength(2000)]
    public string? PARTNER_CONTENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(100)]
    public string? UPD_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string USE_YN { get; set; } = null!;

    [StringLength(100)]
    public string? USE_ADMIN_ID { get; set; }
}
