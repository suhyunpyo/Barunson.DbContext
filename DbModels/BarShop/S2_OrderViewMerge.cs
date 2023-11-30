using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_OrderViewMerge
{
    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    public int order_seq { get; set; }

    public byte? procLevel { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_confirm_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pay_type { get; set; }

    public byte? printW_status { get; set; }

    public int? order_count { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrint { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorInpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEmbo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCorel { get; set; }

    public int? card_seq { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? card_div { get; set; }

    public int? unicef_price { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? print_type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_CODE { get; set; }

    [StringLength(152)]
    [Unicode(false)]
    public string? card_code_str { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? print_group { get; set; }

    public int print_sizeH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDigital { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isinpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;
}
