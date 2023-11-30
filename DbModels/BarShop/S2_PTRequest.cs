using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제휴문의
/// </summary>
public partial class S2_PTRequest
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string com_name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? com_url { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string person_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string person_email { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? hand_phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [Column(TypeName = "text")]
    public string? com_contents { get; set; }

    [Column(TypeName = "text")]
    public string? com_message { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_upfile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1_R { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2_R { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address_R { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? addr_detail_R { get; set; }
}
