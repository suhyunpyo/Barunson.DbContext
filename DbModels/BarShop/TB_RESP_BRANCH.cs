using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_RESP_BRANCH
{
    [StringLength(64)]
    [Unicode(false)]
    public string? mert_id { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? order_seq { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? cflag { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? amount { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? result_msg { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? bank_code { get; set; }
}
