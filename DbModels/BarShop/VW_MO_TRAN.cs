using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_MO_TRAN
{
    public long MO_NUM { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? MO_ACCEPTTIME { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? MO_MODIFIED { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MO_NUMBER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MO_SENDER { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? MO_MSG { get; set; }

    public long? MO_SN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MO_NET { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MO_STATUS { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? MO_REPLY_DATE { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? MO_REPLY_MSG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? act_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(33)]
    [Unicode(false)]
    public string? ACCEPT_DATE { get; set; }

    public int? HANDLE_TIME { get; set; }
}
