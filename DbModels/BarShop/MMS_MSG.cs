using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("MMS_MSG", Schema = "invtmng")]
public partial class MMS_MSG
{
    [Key]
    public long MSGKEY { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? SUBJECT { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PHONE { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string CALLBACK { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string STATUS { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REQDATE { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? MSG { get; set; }

    public int FILE_CNT { get; set; }

    public int? FILE_CNT_REAL { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FILE_PATH1 { get; set; }

    public int? FILE_PATH1_SIZ { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FILE_PATH2 { get; set; }

    public int? FILE_PATH2_SIZ { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FILE_PATH3 { get; set; }

    public int? FILE_PATH3_SIZ { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FILE_PATH4 { get; set; }

    public int? FILE_PATH4_SIZ { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FILE_PATH5 { get; set; }

    public int? FILE_PATH5_SIZ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string EXPIRETIME { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? SENTDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RSLTDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REPORTDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TERMINATEDDATE { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? RSLT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string TYPE { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TELCOINFO { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? POST { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? ETC1 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? ETC2 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? ETC3 { get; set; }

    public int? ETC4 { get; set; }
}
