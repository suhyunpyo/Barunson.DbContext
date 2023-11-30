using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// cs 평가 고객 답변
/// </summary>
public partial class S2_CsPollAns
{
    [Key]
    public int aid { get; set; }

    public int qid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? answer { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? answer_desc { get; set; }

    public int? order_seq { get; set; }
}
