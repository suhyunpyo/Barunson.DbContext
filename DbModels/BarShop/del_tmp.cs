using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class del_tmp
{
    [StringLength(20)]
    [Unicode(false)]
    public string delcode { get; set; } = null!;
}
