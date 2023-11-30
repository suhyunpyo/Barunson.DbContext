using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Tiara_Event
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string phone { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string email { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? etc_info_s { get; set; }

    public int? etc_info_l { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
