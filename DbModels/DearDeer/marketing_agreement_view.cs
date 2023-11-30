using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 마케팅동의노출
/// </summary>
[PrimaryKey("user_id", "agreement_step")]
public partial class marketing_agreement_view
{
    /// <summary>
    /// 회원ID
    /// </summary>
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    /// <summary>
    /// 동의스텝(O:주문, S:샘플주문)
    /// </summary>
    [Key]
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string agreement_step { get; set; } = null!;

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
