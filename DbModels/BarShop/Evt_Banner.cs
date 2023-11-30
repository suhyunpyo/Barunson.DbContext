using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 비핸즈 이벤트 배너관리
/// </summary>
public partial class Evt_Banner
{
    [Key]
    public int seq { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string imgfile_path { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string link_url { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string view_div { get; set; } = null!;

    public int? MD_Choice_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime create_date { get; set; }
}
