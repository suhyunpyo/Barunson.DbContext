using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CJ_DELCODE_TEMP
{
    [Key]
    public int DELCODE_SEQ { get; set; }

    public long CODESEQ { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ISUSE { get; set; } = null!;

    public int? IS_USE { get; set; }
}
