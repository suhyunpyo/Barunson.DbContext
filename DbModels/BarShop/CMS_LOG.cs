using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CMS_LOG
{
    [Key]
    public long id { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string InOut { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? start_time { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? end_time { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string cms_num { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? cname { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? info1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? site { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? qtype { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? msg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
