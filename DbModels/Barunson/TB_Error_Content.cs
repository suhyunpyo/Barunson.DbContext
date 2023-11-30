using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class TB_Error_Content
{
    [Column(TypeName = "text")]
    public string? Error_Content { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Method_Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ID { get; set; }

    [StringLength(100)]
    public string? User_Name { get; set; }
}
