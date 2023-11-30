using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_Admin
{
    /// <summary>
    /// 관리자일련번호
    /// </summary>
    [Key]
    public int AdminID { get; set; }

    /// <summary>
    /// 관리자ID
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string AdminUserID { get; set; } = null!;

    /// <summary>
    /// 관리자비밀번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string AdminPassword { get; set; } = null!;

    /// <summary>
    /// 관리자역할
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? AdminRole { get; set; }

    /// <summary>
    /// 관리자명
    /// </summary>
    [StringLength(30)]
    public string? AdminName { get; set; }

    /// <summary>
    /// 등록시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? RegisterTime { get; set; }
}
