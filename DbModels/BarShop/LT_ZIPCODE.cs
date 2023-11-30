using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class LT_ZIPCODE
{
    [StringLength(4)]
    [Unicode(false)]
    public string? SERVICE_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZIP_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MAIN_CATEGORY_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DESTINATION_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SIDO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GUN_GU { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LAW_DONG { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GOVERNMENT_DONG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DELIVERY_PERIOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_STORE_NAME { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DELIVERY_STORE_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EMPLOYEE_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EMPLOYEE_CODE { get; set; }

    public int? AIRFARE_1 { get; set; }

    public int? AIRFARE_2 { get; set; }

    public int? COLLECT_FERRIAGE { get; set; }

    public int? DELIVERY_FERRIAGE { get; set; }

    public int? COLLECT_LINKING_PAY { get; set; }

    public int? DELIVERY_LINKING_PAY { get; set; }
}
