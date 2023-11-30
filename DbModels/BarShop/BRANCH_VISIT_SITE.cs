using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BRANCH_VISIT_SITE
{
    [StringLength(10)]
    [Unicode(false)]
    public string VDATE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string VDOMAIN { get; set; } = null!;

    public int VCNT { get; set; }

    public short COMPANY_SEQ { get; set; }
}
