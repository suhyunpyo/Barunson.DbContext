using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class VSTAT_ICON
{
    [Key]
    public long id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string usrIP { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_Date { get; set; }
}
