using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Logo_TBL
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LogoName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string lcode { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? lcategory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? filename { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? src_filename { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string flag { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
