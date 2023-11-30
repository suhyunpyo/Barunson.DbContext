using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class antHall
{
    public int wid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Wname { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? wedd_keyword { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Waddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Wphone { get; set; }

    public byte? Wdiv { get; set; }

    public byte? location { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? iscorel { get; set; }

    public int? imgid { get; set; }

    public int? lsort { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    public short? Wcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUpdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAutoWeddInfo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? update_id { get; set; }

    [StringLength(400)]
    public string? WRoadNameAddress { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColor { get; set; }
}
