using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class OB_REF_CODE
{
    public int Code_No { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Field_Name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Field_Value { get; set; } = null!;

    public byte Disp_Order { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Disp_Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Remark { get; set; }
}
