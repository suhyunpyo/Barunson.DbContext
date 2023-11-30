using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Index("MSG_ID", "JOB_ID", Name = "IDX_SDK_F_R_5")]
public partial class SDK_FMS_REPORT
{
    [Key]
    public long MSG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    public long JOB_ID { get; set; }

    public int MSG_SUBTYPE { get; set; }

    public int SCHEDULE_TYPE { get; set; }

    public int DEST_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SUBJECT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOW_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SEND_DATE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CALLBACK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KT_OFFICE_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CDR_ID { get; set; }

    public int DEST_COUNT { get; set; }

    [Column(TypeName = "text")]
    public string DEST_INFO { get; set; } = null!;

    [Column(TypeName = "text")]
    public string ATTACH_FILE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESERVED9 { get; set; }

    public int SUCC_COUNT { get; set; }

    public int FAIL_COUNT { get; set; }

    public int CANCEL_STATUS { get; set; }

    public int CANCEL_COUNT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CANCEL_REQ_DATE { get; set; }

    public int CANCEL_RESULT { get; set; }

    public long? STD_ID { get; set; }
}
