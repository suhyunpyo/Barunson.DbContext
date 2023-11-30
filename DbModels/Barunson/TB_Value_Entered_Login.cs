using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 로그인시 회원이 입력한 값 저장
/// </summary>
[Index("USER_ID", Name = "IX_TB_Value_Entered_Login_USER_ID")]
public partial class TB_Value_Entered_Login
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PASSWORD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DUPINFO { get; set; }

    /// <summary>
    /// 0000 정상
    /// 1000 없음
    /// 2000 두명 이상
    /// 9000 기타 오류
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? RESULT_CODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
