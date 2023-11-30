using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Poll_itemComment
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? comment { get; set; }

    public int? poll_item_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isOpen { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? uphone { get; set; }

    public int? poll_seq { get; set; }
}
