﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_KEY", "IN_TIME")]
[Index("CALLBACK_NO", Name = "IDX_SMSHIST_08_CALLBACK")]
[Index("PROC_RESULT", Name = "IDX_SMSHIST_08_PROCRST")]
[Index("RESULT_TIME", Name = "IDX_SMSHIST_08_RESULT")]
[Index("TR_SECT", Name = "IDX_SMSHIST_08_SDSECT")]
[Index("SERVICE_CODE", Name = "IDX_SMSHIST_08_SVCCODE")]
public partial class T_SMS_HIST_SD_08
{
    [Key]
    public int MSG_KEY { get; set; }

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string IN_TIME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string SERVICE_CODE { get; set; } = null!;

    public int MSG_TYPE { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string CALLEE_NO { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? CALLBACK_NO { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? CALLBACK_URL { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string SMS_MSG { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string SAVE_TIME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string SEND_TIME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string RESULT_TIME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? DELIVERY_TIME { get; set; }

    public int PROC_RESULT { get; set; }

    public int ORDER_FLAG { get; set; }

    public int TR_SECT { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? USER_VAR { get; set; }

    public int? USER_INT { get; set; }
}
