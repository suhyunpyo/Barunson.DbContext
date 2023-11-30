using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_event_question
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string umail { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? question_1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? question_2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? question_3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? question_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? question_5 { get; set; }
}
