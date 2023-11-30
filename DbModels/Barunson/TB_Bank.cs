using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

public partial class TB_Bank
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Bank_Code { get; set; } = null!;

    [StringLength(100)]
    public string? Bank_Name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Use_YN { get; set; }

    public int? Sort { get; set; }
}
