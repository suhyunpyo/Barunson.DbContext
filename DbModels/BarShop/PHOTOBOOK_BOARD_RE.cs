using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_BOARD_RE
{
    [Key]
    public int id { get; set; }

    public short board_id { get; set; }

    public int up_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string member_name { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? contents { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
