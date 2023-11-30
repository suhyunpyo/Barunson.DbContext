using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Discount_Paper
{
    [Key]
    public int DiscountSeq { get; set; }

    public int COMPANY_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DiscountNum { get; set; } = null!;
}
