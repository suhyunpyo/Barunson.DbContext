using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이메일 도메인
/// </summary>
public partial class S2_MailDomain
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string mail_domain { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? domain_msg { get; set; }
}
