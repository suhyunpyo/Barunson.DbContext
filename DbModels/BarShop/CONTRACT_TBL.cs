using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CONTRACT_TBL
{
    public int CON_ID { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CONTRACT_NM { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string CONTRACT_KIND { get; set; } = null!;

    public int CONTRACT_VAL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CONTRACT_SDT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CONTRACT_EDT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string REG_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CHG_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CHG_DT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string STAT { get; set; } = null!;
}
