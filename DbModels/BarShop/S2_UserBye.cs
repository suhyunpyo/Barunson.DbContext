using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 탈퇴 관리
/// </summary>
[Index("uid", Name = "IX_S2_UserBye_uid")]
public partial class S2_UserBye
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_4 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_6 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reason_7 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? reason_txt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? company_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RequestNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AuthType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DupInfo { get; set; }

    [StringLength(88)]
    [Unicode(false)]
    public string? ConnInfo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? BirthDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NationalInfo { get; set; }
}
