using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Evt_Plus_Friends_uid
{
    [Key]
    public int p_idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? p_uid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? p_coupon_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? p_regDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? p_coupon_regdate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? service { get; set; }
}
