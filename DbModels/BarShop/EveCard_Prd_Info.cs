using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EveCard_Prd_Info
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string CP_LoginDate { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Prd_Code { get; set; }

    public short? Order_Num { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Order_Status { get; set; }
}
