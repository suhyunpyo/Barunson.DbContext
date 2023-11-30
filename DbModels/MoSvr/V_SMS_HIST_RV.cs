﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Keyless]
public partial class V_SMS_HIST_RV
{
    public int MSG_KEY { get; set; }

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
