using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_LMS_CONTENT
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string div_info { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string lms_subject { get; set; } = null!;

    [StringLength(4000)]
    [Unicode(false)]
    public string content { get; set; } = null!;
}
