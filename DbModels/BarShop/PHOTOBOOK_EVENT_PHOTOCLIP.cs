using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_EVENT_PHOTOCLIP
{
    [Key]
    public int clip_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string up_image { get; set; } = null!;

    public int view_cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? is_clip { get; set; }
}
