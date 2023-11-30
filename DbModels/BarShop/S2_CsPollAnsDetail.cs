using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// cs 평가 고객 주관식 답변
/// </summary>
[PrimaryKey("qid", "order_seq")]
public partial class S2_CsPollAnsDetail
{
    [Key]
    public int qid { get; set; }

    [Key]
    public int order_seq { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ans_detail { get; set; }
}
