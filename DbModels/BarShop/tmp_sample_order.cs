using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tmp_sample_order
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Member_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Request_Date { get; set; }

    public string? Inflow_Route_Sample { get; set; }

    public string? Sample_Sales_Gubun { get; set; }
}
