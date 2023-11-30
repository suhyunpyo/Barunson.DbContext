using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DEARDEER_SAMPLE_ORDER_MST
{
    [Key]
    public int DEARDEER_SAMPLE_ORDER_MST_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SAMPLE_ORDER_NO { get; set; }

    public int STATUS_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_EMAIL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HOME_PHONE_NUMBER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MOBILE_PHONE_NUMBER { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ZIP_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ADDRESS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ADDRESS_DETAIL { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DELIVERY_COMPANY_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TRACKING_NUMBER { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? INVOICE_PRINT_YORN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? JOB_ORDER_PRINT_YORN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DSP_PRINT_YORN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CLSFADDR { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLLDLVBRANNM { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLLDLCBRANSHORTNM { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLLDLVEMPNM { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLLDLVEMPNICKNM { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLSFCD { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CLSFNM { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SUBCLSFCD { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PREPARE_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
