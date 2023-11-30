using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_trouble2
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? trouble_type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? upfile { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? QcNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RequestOutDate { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? trouble_comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
