using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class XBBS_ARTICLE
{
    [Key]
    public int XA_SEQ { get; set; }

    public int? XI_SEQ { get; set; }

    public int XA_RSEQ { get; set; }

    [StringLength(1528)]
    [Unicode(false)]
    public string XA_TITLE { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string XA_WRITER { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string? XA_WRITER_IP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? XA_PASSWD { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? XA_EMAIL { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? XA_HOMEPAGE { get; set; }

    [Column(TypeName = "text")]
    public string? XA_CONTENT { get; set; }

    public int XA_VIEW_CNT { get; set; }

    public int XA_RECMD_CNT { get; set; }

    public int? XA_THREAD { get; set; }

    public int XA_DEPTH { get; set; }

    public int XA_POSITION { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? XA_FILE { get; set; }

    [ForeignKey("XI_SEQ")]
    [InverseProperty("XBBS_ARTICLE")]
    public virtual XBBS_INFO? XI_SEQNavigation { get; set; }
}
