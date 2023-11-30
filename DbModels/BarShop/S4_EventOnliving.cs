using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 이벤트
/// </summary>
public partial class S4_EventOnliving
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? gubun { get; set; }

    public int? item_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
