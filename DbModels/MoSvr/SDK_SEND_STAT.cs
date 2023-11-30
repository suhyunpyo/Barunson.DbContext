using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("SEND_YEAR", "SEND_MONTH", "SEND_DAY", "SEND_HOUR", "USER_ID")]
public partial class SDK_SEND_STAT
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string SEND_YEAR { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SEND_MONTH { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SEND_DAY { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SEND_HOUR { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    public int SMS_TOTAL { get; set; }

    public int SMS_SUCC { get; set; }

    public int VMS_TTS_TOTAL { get; set; }

    public int VMS_TTS_SUCC { get; set; }

    public int VMS_FILE_TOTAL { get; set; }

    public int VMS_FILE_SUCC { get; set; }

    public int VMS_MSTG_TOTAL { get; set; }

    public int VMS_MSTG_SUCC { get; set; }

    public int VMS_SP_TOTAL { get; set; }

    public int VMS_SP_SUCC { get; set; }

    public int FMS_TOTAL { get; set; }

    public int FMS_SUCC { get; set; }

    public int MMS_TOTAL { get; set; }

    public int MMS_SUCC { get; set; }

    public int THREAD_NO { get; set; }
}
