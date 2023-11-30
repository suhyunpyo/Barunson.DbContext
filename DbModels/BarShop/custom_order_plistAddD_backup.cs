using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("pid", Name = "IX_custom_order_plistAddD_backup_pid")]
public partial class custom_order_plistAddD_backup
{
    public int pid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? event_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_day { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? event_weekname { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? lunar_yes_or_no { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? lunar_event_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? event_ampm { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_minute { get; set; }

    [StringLength(200)]
    public string? wedd_name { get; set; }

    [StringLength(200)]
    public string? wedd_place { get; set; }

    [StringLength(1000)]
    public string? wedd_addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_phone { get; set; }

    public int? wedd_idx { get; set; }

    public int? wedd_imgidx { get; set; }

    public int? map_id { get; set; }

    public int? traffic_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? map_trans_method { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? map_uploadfile { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotMapPrint { get; set; }

    [StringLength(1000)]
    public string? wedd_road_Addr { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? addr_gb { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AddrDirectInd { get; set; }
}
