using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 협찬 Portfolio
/// </summary>
public partial class S4_Portfolio
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(20)]
    public string section_gubun { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string writer { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    public int? card_seq { get; set; }

    [StringLength(200)]
    public string? list_img { get; set; }

    [StringLength(200)]
    public string? thumb_img { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "text")]
    public string? sub_title { get; set; }

    [StringLength(200)]
    public string? sub_img { get; set; }
}
