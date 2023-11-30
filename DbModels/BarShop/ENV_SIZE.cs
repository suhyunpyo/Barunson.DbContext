using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ENV_SIZE
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string env_num { get; set; } = null!;

    public short? env_sizeW { get; set; }

    public short? env_sizeH { get; set; }

    public short? env_sprice { get; set; }
}
