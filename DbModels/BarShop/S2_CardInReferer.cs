using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardInReferer
{
    [StringLength(10)]
    [Unicode(false)]
    public string Card_Code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Use_YorN { get; set; } = null!;
}
