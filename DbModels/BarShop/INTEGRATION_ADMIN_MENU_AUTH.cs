using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class INTEGRATION_ADMIN_MENU_AUTH
{
    [Key]
    public int MENU_AUTH_SEQ { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string MENU_SEQ { get; set; } = null!;

    public int USER_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }
}
