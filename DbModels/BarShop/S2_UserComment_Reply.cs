using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이용후기 답변
/// </summary>
[Index("uc_seq", Name = "IX_S2_UserComment_Reply", IsUnique = true)]
public partial class S2_UserComment_Reply
{
    [Key]
    public int uc_idx { get; set; }

    public int? uc_seq { get; set; }

    [StringLength(50)]
    public string? uc_uname { get; set; }

    [StringLength(500)]
    public string? uc_comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? uc_regdate { get; set; }

    [StringLength(500)]
    public string? uc_admin_comment { get; set; }
}
