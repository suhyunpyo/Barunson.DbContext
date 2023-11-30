using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_TYPE", "NO_KIND", "PHONE_NO")]
public partial class T_SPAM_NO
{
    [Key]
    public int MSG_TYPE { get; set; }

    [Key]
    public int NO_KIND { get; set; }

    [Key]
    [StringLength(32)]
    [Unicode(false)]
    public string PHONE_NO { get; set; } = null!;
}
