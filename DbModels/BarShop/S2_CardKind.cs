using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드종류
/// </summary>
[Keyless]
public partial class S2_CardKind
{
    public int Card_Seq { get; set; }

    public int CardKind_Seq { get; set; }
}
