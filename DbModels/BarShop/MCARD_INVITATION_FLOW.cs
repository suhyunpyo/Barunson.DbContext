using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장 진행 관리
/// </summary>
[PrimaryKey("PCM", "UID")]
public partial class MCARD_INVITATION_FLOW
{
    /// <summary>
    /// 유입경로 : PC / MOBILE
    /// </summary>
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string PCM { get; set; } = null!;

    /// <summary>
    /// 고객ID
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    /// <summary>
    /// 약관동의
    /// </summary>
    public int? STEP0 { get; set; }

    /// <summary>
    /// 스킨선택
    /// </summary>
    public int? STEP1 { get; set; }

    /// <summary>
    /// 정보입력
    /// </summary>
    public int? STEP2 { get; set; }

    /// <summary>
    /// 갤러리관리
    /// </summary>
    public int? STEP3 { get; set; }

    /// <summary>
    /// 제작완료
    /// </summary>
    public int? STEP4 { get; set; }

    /// <summary>
    /// 회원여부(Y:회원 , N:비회원)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? MEM_GB { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CREATE_DATE { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? UPDATE_DATE { get; set; }
}
