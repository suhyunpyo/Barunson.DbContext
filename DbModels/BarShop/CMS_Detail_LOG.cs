using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CMS_Detail_LOG
{
    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? functionName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
