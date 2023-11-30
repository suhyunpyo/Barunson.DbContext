using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 접속정보
/// </summary>
[Keyless]
public partial class ADMIN_CONNECT
{
    /// <summary>
    /// 관리자 아이디
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    /// <summary>
    /// 접속일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? login_date { get; set; }

    /// <summary>
    /// 최종접속시간
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime last_update { get; set; }

    /// <summary>
    /// 아이피
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string login_ip { get; set; } = null!;
}
