using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Ewed_BGM
{
    [Key]
    public int BGM_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Album { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Singer { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Free { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? File_Path { get; set; }

    public bool? State { get; set; }
}
