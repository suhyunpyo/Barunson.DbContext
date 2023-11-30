using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드)서포터즈 이벤트
/// </summary>
public partial class S5_Supporters_User
{
    [Key]
    public int SP_Idx { get; set; }

    public int SP_Company_seq { get; set; }

    [StringLength(20)]
    public string SP_UserID { get; set; } = null!;

    [StringLength(500)]
    public string? SP_URL { get; set; }

    /// <summary>
    /// 0:미승인, 1:미, 2:선, 3:진
    /// </summary>
    public int SP_Level { get; set; }

    /// <summary>
    /// N:미승인, Y:베스트승인
    /// </summary>
    [StringLength(1)]
    public string SP_Best { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SP_Regdate { get; set; }

    /// <summary>
    /// 0:미승인, 1:승인
    /// </summary>
    public int SP_Status { get; set; }

    [StringLength(1000)]
    public string? SP_Comment { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SP_Title { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? SP_Contents { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SP_Auth_Date { get; set; }

    public int? SP_SeasonNo { get; set; }
}
