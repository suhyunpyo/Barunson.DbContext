using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class T_CCG
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cancel_date { get; set; }
}
