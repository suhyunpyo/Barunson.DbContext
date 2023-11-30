using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.MoSvr;

public partial class T_USER_INFO
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string USER_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string USER_PWD { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string USER_NAME { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? CREATE_DATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? LOGIN_DATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? LOGOUT_DATE { get; set; }

    public int? LOGIN_STS { get; set; }
}
