using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("ClientId", "Created")]
public partial class PartnerClientToken
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ClientId { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string RefreshToken { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Expiress { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ClientIp { get; set; } = null!;

    public bool Used { get; set; }
}
