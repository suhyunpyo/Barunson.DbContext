using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_Auth
{
    [Key]
    public int AuthID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string SessionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AuthTime { get; set; }

    [StringLength(30)]
    public string? OrdererName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? OrdererMobile { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? OrdererEmail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MemberYN { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? AuthIP { get; set; }
}
