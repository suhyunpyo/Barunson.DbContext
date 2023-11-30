using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("SC_TRAN", Schema = "invtmng")]
public partial class SC_TRAN
{
    [Key]
    public int TR_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TR_SENDDATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? TR_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TR_SENDSTAT { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? TR_RSLTSTAT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TR_MSGTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TR_PHONE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? TR_CALLBACK { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TR_RSLTDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TR_MODIFIED { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_MSG { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC1 { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC2 { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC3 { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC4 { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC5 { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? TR_ETC6 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TR_NET { get; set; }

    public int? TR_SERIALNUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TR_REALSENDDATE { get; set; }
}
