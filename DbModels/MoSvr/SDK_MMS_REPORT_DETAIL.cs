using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_ID", "SUBJOB_ID")]
[Index("STAT_STATUS", "SEND_DATE", Name = "IDX_SDK_M_RD_6")]
public partial class SDK_MMS_REPORT_DETAIL
{
    [Key]
    public long MSG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    public long JOB_ID { get; set; }

    [Key]
    public int SUBJOB_ID { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? SEND_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DEST_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PHONE_NUMBER { get; set; }

    public int RESULT { get; set; }

    public int? TCS_RESULT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DELIVER_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? READ_TIME { get; set; }

    public int? MOBILE_INFO { get; set; }

    public int? FEE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? REPORT_RES_DATE { get; set; }

    public int STAT_STATUS { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? STIME { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? RTIME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? STATUS_TEXT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SEND_SPID { get; set; }
}
