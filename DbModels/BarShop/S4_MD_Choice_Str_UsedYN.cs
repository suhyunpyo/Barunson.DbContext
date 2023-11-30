using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 메뉴 오픈여부
/// </summary>
[Keyless]
public partial class S4_MD_Choice_Str_UsedYN
{
    public int md_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string used_yn { get; set; } = null!;
}
