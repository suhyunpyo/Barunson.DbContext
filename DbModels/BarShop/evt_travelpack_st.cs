using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class evt_travelpack_st
{
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string travelpack_yn { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regist_Date { get; set; }
}
