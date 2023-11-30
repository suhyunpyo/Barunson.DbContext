using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SMARTAD_COUPON_SUB
{
    [Key]
    public int SMARTAD_COUPON_SUB_SEQ { get; set; }

    public int? SMARTAD_COUPON_MST_SEQ { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? COUPON_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSUE_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
