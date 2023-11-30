using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// cs 팀원 정보
/// </summary>
public partial class S4_CS_Member
{
    [Key]
    public short seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string member_name { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string act_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
