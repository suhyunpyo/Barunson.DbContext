using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_RESULT_LIST
{
    [Key]
    public int seq_idx { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string mailto { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string r_mail { get; set; } = null!;

    public byte return_value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime send_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? return_date { get; set; }
}
