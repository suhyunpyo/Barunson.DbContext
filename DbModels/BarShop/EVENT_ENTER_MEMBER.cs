using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_ENTER_MEMBER
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string EVENT_GUBUN { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MEMBER_ID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
