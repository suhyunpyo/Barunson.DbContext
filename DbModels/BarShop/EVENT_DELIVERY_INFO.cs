using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_DELIVERY_INFO
{
    [Key]
    public int ORDER_SEQ { get; set; }

    [StringLength(40)]
    public string? NAME { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ZIP { get; set; }

    [StringLength(200)]
    public string? ADDR { get; set; }

    [StringLength(100)]
    public string? ADDR_DETAIL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    public int? STATUS { get; set; }
}
