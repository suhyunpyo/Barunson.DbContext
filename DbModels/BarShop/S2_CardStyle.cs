using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드속성 카테고리
/// </summary>
[Keyless]
public partial class S2_CardStyle
{
    public int id { get; set; }

    /// <summary>
    /// S2_CardStyleItme.cardstyle_seq
    /// </summary>
    public int? CardStyle_Seq { get; set; }

    public int? Card_Seq { get; set; }
}
