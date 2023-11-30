using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 마케팅동의(신규)
/// </summary>
[Index("uid", "agreement_type", Name = "UK_S2_UserInfo_Deardeer_Marketing", IsUnique = true)]
public partial class S2_UserInfo_Deardeer_Marketing
{
    /// <summary>
    /// 마케팅동의ID
    /// </summary>
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    /// <summary>
    /// 동의구분
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string agreement_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? agreement_step { get; set; }

    /// <summary>
    /// 동의여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? chk_agreement { get; set; }

    /// <summary>
    /// 동의일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? agree_date { get; set; }

    /// <summary>
    /// 취소일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? cancel_date { get; set; }

    /// <summary>
    /// 취소아이디
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? cancel_uid { get; set; }
}
