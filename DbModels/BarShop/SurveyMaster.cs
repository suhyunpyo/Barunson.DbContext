using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드)설문 이벤트
/// </summary>
public partial class SurveyMaster
{
    [Key]
    public int SurveyNo { get; set; }

    public int CompanySeq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SalesGubun { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? SendMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string UseYN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDT { get; set; }
}
