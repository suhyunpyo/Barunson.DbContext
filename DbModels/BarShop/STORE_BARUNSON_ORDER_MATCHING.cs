using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class STORE_BARUNSON_ORDER_MATCHING
{
    [Key]
    public int Uid { get; set; }

    public int Order_Seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Reg_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Last_Matching_Date { get; set; }
}
