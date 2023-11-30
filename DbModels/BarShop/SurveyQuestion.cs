using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 설문이벤트 질문
/// </summary>
[PrimaryKey("SurveyNo", "QuestionNo")]
public partial class SurveyQuestion
{
    [Key]
    public int SurveyNo { get; set; }

    [Key]
    public int QuestionNo { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string QuestionText { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string UseYN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDT { get; set; }
}
