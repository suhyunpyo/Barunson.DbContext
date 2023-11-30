using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class s4_poll_user_reply
{
    [Key]
    public int seq { get; set; }

    public int poll_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int poll_item_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
