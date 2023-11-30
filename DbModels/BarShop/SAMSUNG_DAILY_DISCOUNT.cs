using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class SAMSUNG_DAILY_DISCOUNT
{
    public int seq { get; set; }

    [StringLength(88)]
    [Unicode(false)]
    public string? conninfo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_smembership { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? smembership_reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? smembership_leave_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_smembership_leave { get; set; }

    public int? order_seq { get; set; }

    public int? up_order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_Gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? site_gubun { get; set; }

    public int? company_seq { get; set; }

    public int? status_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }

    public byte? settle_status { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    public int? settle_price { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? discount_in_advance { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_cancel_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date_s { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }
}
