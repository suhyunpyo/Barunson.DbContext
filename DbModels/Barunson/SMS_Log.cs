using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class SMS_Log
{
    [StringLength(50)]
    [Unicode(false)]
    public string? ORDER_CDOE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }

    [Column(TypeName = "text")]
    public string? CONTENT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ORDER_HPHONE { get; set; }
}
