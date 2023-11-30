using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("uid", "agreement_step")]
public partial class S2_UserInfo_Deardeer_Marketing_View
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string agreement_step { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mod_date { get; set; }
}
