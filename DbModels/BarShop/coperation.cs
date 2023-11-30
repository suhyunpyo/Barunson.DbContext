using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class coperation
{
    public int coperation_seq { get; set; }

    public int con_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
