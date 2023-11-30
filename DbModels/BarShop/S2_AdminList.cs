using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 아이디
/// </summary>
[Index("admin_id", Name = "IX_S2_AdminList_id", IsUnique = true)]
public partial class S2_AdminList
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? admin_pwd { get; set; }

    [MaxLength(256)]
    public byte[]? password { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string admin_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? admin_mail { get; set; }

    public byte admin_level { get; set; }

    public int? company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is_reviewMail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is_errorMail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is_reviewSMS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_hphone { get; set; }

    [StringLength(500)]
    public string? admin_photo { get; set; }

    public int? access_flag { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JOB_NAME { get; set; }
}
