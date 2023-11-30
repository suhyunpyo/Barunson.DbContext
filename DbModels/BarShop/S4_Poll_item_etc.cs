using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Poll_item_etc
{
    [Key]
    public int seq { get; set; }

    public int poll_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string item_comment { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
