using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class TB_Coupon_Exception_Product
{
    [StringLength(6)]
    [Unicode(false)]
    public string? Product_Code { get; set; }

    public int? Product_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }
}
