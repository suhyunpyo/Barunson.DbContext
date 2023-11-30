using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Delivery_Price_Info
{
    [Key]
    public int Seq { get; set; }

    public int Add_Delivery_Price1 { get; set; }

    public int Add_delivery_Price2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(50)]
    public string? CreatedUserid { get; set; }
}
