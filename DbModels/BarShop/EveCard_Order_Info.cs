using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EveCard_Order_Info
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CP_LoginDate { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CP_Name { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string CP_Number { get; set; } = null!;

    public int Order_Price { get; set; }

    public int Order_SalePrice { get; set; }

    public int Order_FixPrice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Order_Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Order_Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Admin_Name { get; set; }

    [Column(TypeName = "text")]
    public string? Memo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Company_Number { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }
}
