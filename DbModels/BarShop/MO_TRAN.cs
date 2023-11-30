using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("MO_TRAN", Schema = "invtmng")]
public partial class MO_TRAN
{
    [Key]
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

    [StringLength(1000)]
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

    [StringLength(1000)]
    [Unicode(false)]
    public string? MO_REPLY_MSG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? act_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? site_gubun { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? IMAGE1 { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? IMAGE2 { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? IMAGE3 { get; set; }
}
