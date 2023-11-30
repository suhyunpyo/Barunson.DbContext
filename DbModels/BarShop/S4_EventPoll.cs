using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_EventPoll
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
