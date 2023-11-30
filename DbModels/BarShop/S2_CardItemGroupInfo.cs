using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardItemGroupInfo
{
    [Key]
    public int CardItemGroup_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CardItemGroup { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CardItemGroup_Div { get; set; }
}
