using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BHANDS_MEMBER_TEMP_TABLE
{
    [StringLength(255)]
    public string? ID { get; set; }

    [StringLength(255)]
    public string? phone { get; set; }

    [StringLength(255)]
    public string? name { get; set; }

    [StringLength(255)]
    public string? email { get; set; }
}
