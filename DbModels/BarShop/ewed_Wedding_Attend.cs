using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Wedding_Attend
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string rname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string rmail { get; set; } = null!;

    public byte result { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? attend_yn { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? note { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? senderDiv { get; set; }
}
