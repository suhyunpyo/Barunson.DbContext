using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PartnerClient
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ClientId { get; set; } = null!;

    [MaxLength(256)]
    public byte[] ClientSecret { get; set; } = null!;

    [StringLength(100)]
    public string ClientName { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime RegisterDate { get; set; }

    public bool Active { get; set; }
   
}
