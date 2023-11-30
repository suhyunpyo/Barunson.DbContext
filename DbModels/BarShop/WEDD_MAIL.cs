using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 메일,SMS 발송관리
/// </summary>
public partial class WEDD_MAIL
{
    [Key]
    public int id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int? company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string div { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? div_s2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sms_phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? email_sender { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? sms_msg { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? email_title { get; set; }

    [StringLength(7800)]
    [Unicode(false)]
    public string? email_msg { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }
}
