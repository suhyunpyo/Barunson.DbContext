using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

public partial class sweetday
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int id { get; set; }
}
