using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("S4_EventManager", Schema = "invtmng")]
public partial class S4_EventManager
{
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EventName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string EventUrl { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public byte EventKind { get; set; }

    [Unicode(false)]
    public string ManagerComment { get; set; } = null!;

    public byte isDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EventListImage { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string EventDescription { get; set; } = null!;

    public byte isJehu { get; set; }
}
