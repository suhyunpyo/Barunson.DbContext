using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_CardClickCount
{
    public int card_seq { get; set; }

    public int click_count { get; set; }

    public int company_seq { get; set; }
}
