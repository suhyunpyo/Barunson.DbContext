using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class PrintChasuGroupDetail
{
    public int Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    public short GroupCodeSeq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CardCode { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PrintType { get; set; } = null!;
}
