using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class tb_test22
{
    [StringLength(1)]
    [Unicode(false)]
    public string? GUBUN { get; set; }

    public int? GUBUN2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_EMAIL { get; set; }
}
