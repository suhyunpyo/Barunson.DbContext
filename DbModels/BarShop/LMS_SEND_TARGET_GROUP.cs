using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class LMS_SEND_TARGET_GROUP
{
    [Key]
    public int GROUP_SEQ { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? SUBJECT { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? MSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RESERVATION_DATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RQEUST_ADMIN_NAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
