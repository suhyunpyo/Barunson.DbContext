using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("event_type", Name = "NCI_Event_View_Log_Event_Type")]
public partial class Event_View_Log
{
    [Key]
    public long seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string event_type { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string ip { get; set; } = null!;

    [StringLength(1000)]
    public string? agent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? device { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? reg_date_str { get; set; }

    public short? hour { get; set; }

    public short? day { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? point { get; set; }

    [StringLength(255)]
    public string? referer { get; set; }
}
