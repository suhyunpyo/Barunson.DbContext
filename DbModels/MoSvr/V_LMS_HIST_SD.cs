using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Keyless]
public partial class V_LMS_HIST_SD
{
    public int MSG_KEY { get; set; }

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
    public string SUBJECT { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string LMS_MSG { get; set; } = null!;

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
