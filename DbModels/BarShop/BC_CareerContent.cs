using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 채용내용
/// </summary>
public partial class BC_CareerContent
{
    [Key]
    public int CareerContent_Seq { get; set; }

    public int Career_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Unicode(false)]
    public string? Contents { get; set; }
}
