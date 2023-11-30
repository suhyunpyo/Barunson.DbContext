using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DatabaseChangeHistory
{
    [Key]
    public int EventID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ObjectName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EventType { get; set; }

    [Unicode(false)]
    public string? CommandText { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HostName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HostIP { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EventDT { get; set; }
}
