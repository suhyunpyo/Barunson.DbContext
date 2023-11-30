using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_PB_SIZE
{
    public int? IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SIZE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PAGES { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_PRICE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_TYPE { get; set; }
}
