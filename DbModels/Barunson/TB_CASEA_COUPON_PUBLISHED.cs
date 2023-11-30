using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class TB_CASEA_COUPON_PUBLISHED
{
    public int? Order_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Member_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }
}
