using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_SMS
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string from_no { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string to_no { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string to_message { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ret_value { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }
}
