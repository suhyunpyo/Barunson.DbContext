using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class LOG_AGENT_CHECK
{
    [Key]
    public int LOG_SEQ { get; set; }

    [StringLength(400)]
    public string? LOG_AGENT { get; set; }

    [StringLength(400)]
    public string? UID { get; set; }

    [StringLength(10)]
    public string? SALES_GUBUN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
