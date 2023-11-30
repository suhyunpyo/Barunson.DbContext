using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DeliveryPriceInfo
{
    [Key]
    public int Seq { get; set; }

    public int AddDeliveryPrice1 { get; set; }

    public int AddDeliveryPrice2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(50)]
    public string? CreatedUserid { get; set; }
}
