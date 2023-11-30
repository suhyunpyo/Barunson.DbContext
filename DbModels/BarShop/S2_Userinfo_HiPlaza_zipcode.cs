using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("si_do", "gu_gun", "zipcode")]
public partial class S2_Userinfo_HiPlaza_zipcode
{
    [Key]
    [StringLength(20)]
    public string si_do { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string gu_gun { get; set; } = null!;

    [Key]
    [StringLength(6)]
    public string zipcode { get; set; } = null!;
}
