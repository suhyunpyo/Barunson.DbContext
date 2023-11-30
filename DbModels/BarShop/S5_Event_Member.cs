using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S5_Event_Member
{
    public int CEM_Idx { get; set; }

    public int? CEM_Item { get; set; }

    [StringLength(50)]
    public string? CEM_UID { get; set; }

    public int CEM_Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CEM_Regdate { get; set; }
}
