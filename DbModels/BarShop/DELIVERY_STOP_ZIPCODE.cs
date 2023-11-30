using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DELIVERY_STOP_ZIPCODE
{
    [Key]
    public int ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string GUBUN { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string ZIP { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REGDATE { get; set; }
}
