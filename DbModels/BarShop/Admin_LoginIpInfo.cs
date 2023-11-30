using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 접속 로그
/// </summary>
public partial class Admin_LoginIpInfo
{
    /// <summary>
    /// 순번
    /// </summary>
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// 관리자id
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    /// <summary>
    /// 관리자명
    /// </summary>
    [StringLength(50)]
    public string? uname { get; set; }

    /// <summary>
    /// 관리자 이메일
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string ip { get; set; } = null!;

    /// <summary>
    /// 유입 url
    /// </summary>
    [StringLength(500)]
    public string? referer_url { get; set; }

    [StringLength(4000)]
    public string? user_agent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }
}
