using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class DD_JEHU_LINK
{
    [StringLength(20)]
    [Unicode(false)]
    public string COMPANY_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }
}
