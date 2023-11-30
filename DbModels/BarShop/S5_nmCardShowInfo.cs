using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Order_Seq", "ShowIndex")]
public partial class S5_nmCardShowInfo
{
    [Key]
    public int Order_Seq { get; set; }

    [Key]
    public int ShowIndex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ShowHash { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ShakrInstanceId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StyleSlug { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowViewUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowViewAliasUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowViewAliasHdUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowViewAliasSdUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowHdDownUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShowSdDownUrl { get; set; }

    public short EditSIstatus { get; set; }

    public short EditSSstatus { get; set; }

    public short EditSCstatus { get; set; }

    public short EditECstatus { get; set; }

    public int RenderProgress { get; set; }

    public int ShowStatus { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PurchasedStatus { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime ModDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DelFlag { get; set; } = null!;

    [StringLength(200)]
    public string? Skin_img { get; set; }
}
