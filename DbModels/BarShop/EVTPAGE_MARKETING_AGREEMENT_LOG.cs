using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class EVTPAGE_MARKETING_AGREEMENT_LOG
{
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string jehu_gubun { get; set; } = null!;
}
