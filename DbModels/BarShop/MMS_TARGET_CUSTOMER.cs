using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class MMS_TARGET_CUSTOMER
{
    [Key]
    public int SEQ { get; set; }

    public int? COMPANY_SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? SUBJECT { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? MSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
