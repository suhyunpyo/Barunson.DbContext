using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class VW_Admin
{
    [StringLength(50)]
    [Unicode(false)]
    public string ADMIN_NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ADMIN_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ADMIN_PASSWORD { get; set; } = null!;

    public byte ADMIN_TYPE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REGIST_DATETIME { get; set; }
}
