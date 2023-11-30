using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// cs 평가 질문/답변 관리
/// </summary>
public partial class S2_CsPoll
{
    public int company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string status { get; set; } = null!;

    [Key]
    public int id { get; set; }

    public short seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    /// <summary>
    /// 1:라디오,2:체크박스,3:구문입력
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string qtype { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? answer1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? answer8 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    public short? answer_cnt { get; set; }
}
