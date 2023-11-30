using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp_gift_company
{
    [StringLength(50)]
    [Unicode(false)]
    public string? company_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pw { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? company_type_code { get; set; }
}
