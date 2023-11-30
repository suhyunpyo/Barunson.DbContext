using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("UID", Name = "IX_JEHU_COUPONBOX_ISSUE_UID")]
[Index("jehu_company", "SalesGubun", Name = "uci_JEHU_COUPONBOX_ISSUE_jehu_company_salesgubun")]
public partial class JEHU_COUPONBOX_ISSUE
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string jehu_company { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SalesGubun { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end_date { get; set; }
}
