using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("RECV_YEAR", "RECV_MONTH", "RECV_DAY", "RECV_HOUR")]
public partial class SDK_RECV_STAT
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string RECV_YEAR { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string RECV_MONTH { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string RECV_DAY { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string RECV_HOUR { get; set; } = null!;

    public int SMS_TOTAL { get; set; }

    public int FMS_TOTAL { get; set; }
}
