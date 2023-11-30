using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_KEY", "IN_TIME")]
[Index("CALLBACK_NO", Name = "IDX_RVHIST_08_CALLBACK")]
[Index("CALLER_NO", Name = "IDX_RVHIST_08_CALLER")]
[Index("READ_FLAG", Name = "IDX_RVHIST_08_READ")]
[Index("RV_SECT", Name = "IDX_RVHIST_08_RVSECT")]
[Index("SERVICE_CODE", Name = "IDX_RVHIST_08_SVCCODE")]
public partial class T_SMS_HIST_RV_08
{
    [Key]
    public int MSG_KEY { get; set; }

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string IN_TIME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? SERVICE_CODE { get; set; }

    public int? MSG_TYPE { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string CALLER_NO { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string CALLEE_NO { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? CALLBACK_NO { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string SMS_MSG { get; set; } = null!;

    public int? RV_SECT { get; set; }

    public int? READ_FLAG { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string SUBMIT_TIME { get; set; } = null!;
}
