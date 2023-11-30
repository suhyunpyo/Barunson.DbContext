using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class UserTokenInfo
{
    [Key]
    public Guid guid_id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? access_token { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
