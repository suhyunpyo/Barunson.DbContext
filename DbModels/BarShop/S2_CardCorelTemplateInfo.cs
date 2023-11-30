using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// ERP카드그룹 관리&lt;br&gt;
/// </summary>
public partial class S2_CardCorelTemplateInfo
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GROUP_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERP_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INSIDE_PRINT_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? OUTSIDE_PRINT_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
