using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 설문이벤트 답변참여
/// </summary>
[PrimaryKey("SurveyNo", "QuestionNo", "ResponseNo")]
public partial class SurveyResponse
{
    [Key]
    public int SurveyNo { get; set; }

    [Key]
    public int QuestionNo { get; set; }

    [Key]
    public int ResponseNo { get; set; }

    public int? ReplyAnswerNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MemberID { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDT { get; set; }
}
