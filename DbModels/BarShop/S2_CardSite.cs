using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardSite
{
    [Key]
    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string site_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string site_url { get; set; } = null!;
}
