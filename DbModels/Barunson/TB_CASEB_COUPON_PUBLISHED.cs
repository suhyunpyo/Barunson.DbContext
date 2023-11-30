using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
[Index("Member_ID", Name = "IX_NC_TB_CASEB_COUPON_PUBLISHED_member_id")]
public partial class TB_CASEB_COUPON_PUBLISHED
{
    public int? Order_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Member_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }
}
