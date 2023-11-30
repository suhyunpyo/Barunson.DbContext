using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class SS_MMS_SEND_20190910
{
    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PHONE_RECEIVER { get; set; }
}
