using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_MEMBER_OUT
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans6 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ans7 { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ans_detail { get; set; }
}
