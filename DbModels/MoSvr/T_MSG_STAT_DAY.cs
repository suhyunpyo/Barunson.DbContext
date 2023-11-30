using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("RAISE_DATE", "MSG_TYPE", "SERVICE_CODE", "DIRECTION", "SR_SECT")]
public partial class T_MSG_STAT_DAY
{
    [Key]
    [StringLength(14)]
    [Unicode(false)]
    public string RAISE_DATE { get; set; } = null!;

    [Key]
    public int MSG_TYPE { get; set; }

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string SERVICE_CODE { get; set; } = null!;

    [Key]
    public int DIRECTION { get; set; }

    [Key]
    public int SR_SECT { get; set; }

    public int TRY_CNT { get; set; }

    public int SUCC_CNT { get; set; }

    public int FAIL_00 { get; set; }

    public int FAIL_01 { get; set; }

    public int FAIL_02 { get; set; }

    public int FAIL_03 { get; set; }

    public int FAIL_04 { get; set; }

    public int FAIL_05 { get; set; }

    public int FAIL_06 { get; set; }

    public int FAIL_07 { get; set; }

    public int FAIL_08 { get; set; }

    public int FAIL_09 { get; set; }

    public int? FAIL_10 { get; set; }

    public int? FAIL_11 { get; set; }

    public int? FAIL_12 { get; set; }

    public int? FAIL_13 { get; set; }

    public int? FAIL_14 { get; set; }

    public int? FAIL_15 { get; set; }
}
