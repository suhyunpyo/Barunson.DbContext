using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class mobile_ad_visit
{
    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string ip { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime create_date { get; set; }
}
