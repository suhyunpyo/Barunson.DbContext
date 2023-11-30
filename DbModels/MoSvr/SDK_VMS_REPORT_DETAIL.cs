using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_ID", "SUBJOB_ID")]
[Index("STAT_STATUS", "SEND_DATE", Name = "IDX_SDK_V_RD_7")]
public partial class SDK_VMS_REPORT_DETAIL
{
    [Key]
    public long MSG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    public long JOB_ID { get; set; }

    [Key]
    public int SUBJOB_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SEND_DATE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DEST_NAME { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PHONE_NUMBER { get; set; } = null!;

    public int RESULT { get; set; }

    public int? TCS_RESULT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STIME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RTIME { get; set; }

    public double? FEE { get; set; }

    public int DURATION { get; set; }

    public int REPLIED_DTMF { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? REPLIED_FILE { get; set; }

    public int REPORT_STATUS { get; set; }

    public int REPORT_COUNT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? REPORT_REQ_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? REPORT_RES_DATE { get; set; }

    public int? MSG_SUBJOB_TYPE { get; set; }

    public int STAT_STATUS { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? STATUS_TEXT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SEND_SPID { get; set; }
}
