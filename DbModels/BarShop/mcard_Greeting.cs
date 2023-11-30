using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_Greeting
{
    [Key]
    public int GreetingID { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string InvitationType { get; set; } = null!;

    [StringLength(20)]
    public string? GreetingType { get; set; }

    [StringLength(500)]
    public string GreetingWord { get; set; } = null!;

    public int GreetingOrder { get; set; }
}
