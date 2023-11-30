using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 비회원 S M S  여부 관리
/// </summary>
public partial class S4_NonUserInfo_Sms
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? sms_chk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(10)]
    public string? inflow_route { get; set; }

    public int order_seq { get; set; }
}
