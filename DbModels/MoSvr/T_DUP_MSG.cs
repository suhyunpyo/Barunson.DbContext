using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

[PrimaryKey("MSG_TYPE", "PHONE_NO", "SEND_TIME")]
public partial class T_DUP_MSG
{
    [Key]
    public int MSG_TYPE { get; set; }

    [Key]
    [StringLength(32)]
    [Unicode(false)]
    public string PHONE_NO { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string SEND_MSG { get; set; } = null!;

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string SEND_TIME { get; set; } = null!;
}
