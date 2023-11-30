using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 초대장_상세_기타
/// </summary>
[PrimaryKey("Invitation_ID", "Sort")]
public partial class TB_Invitation_Detail_Etc
{
    /// <summary>
    /// 초대장_ID
    /// </summary>
    [Key]
    public int Invitation_ID { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    [Key]
    public int Sort { get; set; }

    /// <summary>
    /// 기타_제목
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Etc_Title { get; set; }

    /// <summary>
    /// 정보_내용
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Information_Content { get; set; }

    [ForeignKey("Invitation_ID")]
    [InverseProperty("TB_Invitation_Detail_Etc")]
    public virtual TB_Invitation Invitation { get; set; } = null!;
}
