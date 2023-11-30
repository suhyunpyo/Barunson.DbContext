using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CARD_FREE_FOOD_TICKET_MST_TEST
{
    [Key]
    public int SEQ { get; set; }

    public int CARD_SEQ { get; set; }

    public int COMPANY_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime END_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string USE_JEHU_YORN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string USE_YORN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
