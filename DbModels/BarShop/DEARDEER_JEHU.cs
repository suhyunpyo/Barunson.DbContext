using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class DEARDEER_JEHU
{
    [StringLength(50)]
    [Unicode(false)]
    public string COMPANY_NAME { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string COMPANY_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regist_Date { get; set; }
}
