using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Evt_Plus_Friends
{
    [Key]
    public int pf_idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pf_uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pf_fuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pf_regDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pf_coupon_status_f { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? service { get; set; }
}
