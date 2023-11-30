using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class history
{
    [StringLength(255)]
    public string? YID { get; set; }

    [StringLength(255)]
    public string? YOwner { get; set; }

    [StringLength(255)]
    public string? YPeerID { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? YDatetime { get; set; }

    [StringLength(255)]
    public string? YDuration { get; set; }

    [StringLength(255)]
    public string? YType { get; set; }

    [StringLength(255)]
    public string? YUniqueid { get; set; }

    [StringLength(255)]
    public string? YMemo { get; set; }
}
