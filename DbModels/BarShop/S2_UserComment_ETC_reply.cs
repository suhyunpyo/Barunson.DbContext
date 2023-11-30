using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 프페부가상품 이용후기
/// </summary>
public partial class S2_UserComment_ETC_reply
{
    [Key]
    public int uc_idx { get; set; }

    public int? uc_seq { get; set; }

    [StringLength(100)]
    public string? uc_uname { get; set; }

    [Column(TypeName = "ntext")]
    public string? uc_comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? uc_regdate { get; set; }
}
