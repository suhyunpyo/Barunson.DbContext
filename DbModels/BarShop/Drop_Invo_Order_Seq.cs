using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Drop_Invo_Order_Seq
{
    [Key]
    public int Id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Gubun { get; set; } = null!;

    public int Order_Seq { get; set; }

    public int? Delivery_Seq { get; set; }
}
