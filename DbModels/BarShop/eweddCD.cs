using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class eweddCD
{
    [Key]
    public int ewedd_id { get; set; }

    [StringLength(255)]
    public string? order_seq { get; set; }

    [StringLength(255)]
    public string? userid { get; set; }

    [StringLength(255)]
    public string? username { get; set; }

    [StringLength(255)]
    public string? useremail { get; set; }

    [StringLength(255)]
    public string? settle_date { get; set; }

    [StringLength(255)]
    public string? settle_cancle_date { get; set; }

    [StringLength(255)]
    public string? settle_price { get; set; }

    [StringLength(255)]
    public string? order_date { get; set; }

    [StringLength(255)]
    public string? productID { get; set; }

    public double? writenum { get; set; }

    public double? visitwrite { get; set; }

    public double? visitnum { get; set; }

    public double? ewedd_sum { get; set; }

    [StringLength(255)]
    public string? result { get; set; }

    [StringLength(255)]
    public string? order_result { get; set; }

    [StringLength(255)]
    public string? settle_status { get; set; }

    [StringLength(255)]
    public string? status_seq { get; set; }

    public bool send_ok { get; set; }
}
