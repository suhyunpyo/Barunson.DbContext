using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 로그인 정보
/// </summary>
[Keyless]
public partial class S4_LoginIpInfo
{
    public int SEQ { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(50)]
    public string? UNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UMAIL { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string IP { get; set; } = null!;

    [StringLength(2000)]
    public string? REFERER_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DEVICE_TYPE_NAME { get; set; }

    [StringLength(400)]
    public string? AGENT_TYPE { get; set; }
}
