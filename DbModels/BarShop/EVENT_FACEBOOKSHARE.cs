using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_FACEBOOKSHARE
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? site_div { get; set; }

    public int? event_year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
