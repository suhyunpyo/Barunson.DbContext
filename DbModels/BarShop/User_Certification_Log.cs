using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("CertID", Name = "IX_User_Certification_Log_CertID", IsUnique = true)]
[Index("RegDate", Name = "IX_User_Certification_Log_RegDate")]
public partial class User_Certification_Log
{
    /// <summary>
    /// 시퀀스
    /// </summary>
    [Key]
    public int CertSeq { get; set; }

    /// <summary>
    /// 인증고유 ID (웹에서 db access용으로 사용)
    /// </summary>
    [StringLength(37)]
    [Unicode(false)]
    public string CertID { get; set; } = null!;

    /// <summary>
    /// 인증방식 구분 ( CPClient:통합인증, IPIN:아이핀, NONE:인증없이 di전달용)
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string CertType { get; set; } = null!;

    /// <summary>
    /// 고유 개인정보
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? DupInfo { get; set; }

    /// <summary>
    /// 인증 데이터
    /// </summary>
    [StringLength(2048)]
    [Unicode(false)]
    public string? CertData { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}
