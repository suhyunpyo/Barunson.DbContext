using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Event_Review_Sub
{
    [Key]
    public int ERS_Idx { get; set; }

    public int ERS_ER_Idx { get; set; }

    [StringLength(20)]
    public string? ERS_UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ERS_Regdate { get; set; }
}
