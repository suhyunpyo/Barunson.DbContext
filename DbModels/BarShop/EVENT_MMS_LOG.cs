using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("UID", Name = "INDEX_UID_IDX1")]
public partial class EVENT_MMS_LOG
{
    [StringLength(10)]
    [Unicode(false)]
    public string SEND_DT { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EVENT_GB { get; set; } = null!;
}
