using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_WEDDING_HALL
{
    public int wid { get; set; }

    public int wedd_idx { get; set; }

    public byte? Wdiv { get; set; }

    public byte? location { get; set; }

    public short? Wcnt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Wname { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Waddress { get; set; }

    [StringLength(400)]
    public string? WRoadNameAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Wphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? corelFolder { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? flag { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? iscorel { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isAutoupdate { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isIllur { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isIllur_update { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AREA { get; set; }

    public int? POI { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? map_admin_id { get; set; }

    public int? ranking { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? waddress_detail { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? wedd_keyword { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? update_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAutoWeddInfo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUpdate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? poi_id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? poi_x { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? poi_y { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? poi_matching { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JOB_ID { get; set; }

    public int? IMGID { get; set; }

    public int BLACK_CNT { get; set; }

    public int COLOR_CNT { get; set; }
}
