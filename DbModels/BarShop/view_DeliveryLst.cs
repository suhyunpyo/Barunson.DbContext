using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_DeliveryLst
{
    [StringLength(1)]
    [Unicode(false)]
    public string OTYPE { get; set; } = null!;

    public int ORDER_SEQ { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    public int? COMPANY_SEQ { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string COMPANY_NAME { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RECV_NAME { get; set; }

    [StringLength(601)]
    [Unicode(false)]
    public string? RECV_ADDRESS { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? DELIVERY_COM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ERP_PARTCODE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PACKING_DATE { get; set; }
}
