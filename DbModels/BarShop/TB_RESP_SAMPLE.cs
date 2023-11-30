using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_RESP_SAMPLE
{
    [StringLength(15)]
    [Unicode(false)]
    public string mert_id { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string order_seq { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? amount { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? bank_code { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? result_msg { get; set; }
}
