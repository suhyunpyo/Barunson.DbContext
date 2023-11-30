using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class s2_event_UserComment_url
{
    [Key]
    public int c_idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? c_uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string c_uname { get; set; } = null!;

    public int c_order_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime c_regDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string c_title { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string c_url { get; set; } = null!;

    public int c_score { get; set; }

    public int c_status { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? c_cancle_reply { get; set; }
}
