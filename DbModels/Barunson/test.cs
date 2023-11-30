using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class test
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Order_Code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? resultMSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
