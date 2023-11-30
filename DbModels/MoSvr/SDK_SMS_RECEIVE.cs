using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Index("MSG_ID", Name = "IDX_SDK_S_RC_1")]
[Index("STAT_STATUS", "RECV_DATE", Name = "IDX_SDK_S_RC_7")]
public partial class SDK_SMS_RECEIVE
{
    [Key]
    public long JOB_ID { get; set; }

    public long MSG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CALLBACK { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ANI_NUMBER { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DEST_NUMBER { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SMS_MSG { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RECV_DATE { get; set; } = null!;

    public int REPORT_STATUS { get; set; }

    public int REPORT_COUNT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? REPORT_PROC_TIME { get; set; }

    public int REPORT_RESULT { get; set; }

    public int STAT_STATUS { get; set; }
}
