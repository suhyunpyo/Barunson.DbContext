using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class Origin_Invitation_Detail
{
    public int? Order_ID { get; set; }

    public int? Invitation_ID { get; set; }

    [StringLength(200)]
    public string? Origin_Invitation_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }
}
