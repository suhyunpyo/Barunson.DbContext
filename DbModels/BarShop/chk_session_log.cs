using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class chk_session_log
{
    [StringLength(50)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    public int order_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }
}
