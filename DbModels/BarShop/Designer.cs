using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 디자이너 정보
/// </summary>
public partial class Designer
{
    [Key]
    public int DesignerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DesignerCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Pwd { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }
}
