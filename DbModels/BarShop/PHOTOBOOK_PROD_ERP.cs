using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("PHOTOBOOK_PROD_ERP", Schema = "invtmng")]
public partial class PHOTOBOOK_PROD_ERP
{
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    public short prod_page { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? erp_code { get; set; }
}
