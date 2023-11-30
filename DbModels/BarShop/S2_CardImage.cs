using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("CardImage_WSize", "CardImage_HSize", "CardImage_Div", "Company_Seq", Name = "IDX_S2_CardImage_CardImage_WSize_CardImage_HSize_CardImage_Div_Company_Seq")]
public partial class S2_CardImage
{
    [Key]
    public int CardImage_Seq { get; set; }

    public int Card_Seq { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CardImage_WSize { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CardImage_HSize { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CardImage_FileName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CardImage_Div { get; set; }

    public int? Company_Seq { get; set; }
}
