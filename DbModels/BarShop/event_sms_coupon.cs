using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class event_sms_coupon
{
    [Key]
    public int seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? hphone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }
}
