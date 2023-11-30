using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Index("STAT_STATUS", "RECV_DATE", Name = "IDX_SDK_F_RC_2")]
public partial class SDK_FMS_RECEIVE
{
    [Key]
    public long JOB_ID { get; set; }

    public int? SUBJOB_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ANI_NUMBER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DEST_NUMBER { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? FILE_NAME { get; set; }

    public int RESULT { get; set; }

    public int? TCS_RESULT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STIME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RTIME { get; set; }

    public double? FEE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DURATION { get; set; }

    public int FAX_PAGE { get; set; }

    public long MSG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RECV_DATE { get; set; }

    public int STAT_STATUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UMS_MEMO { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? DEL_TM { get; set; }
}
