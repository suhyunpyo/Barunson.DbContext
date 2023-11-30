using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_ProductImage
{
    [StringLength(30)]
    [Unicode(false)]
    public string? Card_Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CardImage_Name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CardImage_DIV { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CardImage_WSize { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CardImage_HSize { get; set; }
}
