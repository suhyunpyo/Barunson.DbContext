using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class UserInfo_Bhands_ci
{
    [StringLength(255)]
    public string? no { get; set; }

    [StringLength(255)]
    public string? uname { get; set; }

    [StringLength(255)]
    public string? uid { get; set; }

    [StringLength(255)]
    public string? DupInfo { get; set; }

    [StringLength(255)]
    public string? ConnInfo { get; set; }
}
