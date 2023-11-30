using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[Keyless]
public partial class T_CODE
{
    [StringLength(4)]
    [Unicode(false)]
    public string CODE_GROUP { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string CODE_NAME { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DELETE_YN { get; set; } = null!;
}
