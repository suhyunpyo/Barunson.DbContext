using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Order_MemoDay
{
    [Key]
    public int m_seq { get; set; }

    public int order_seq { get; set; }

    public byte seq { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string m_year { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string m_month { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string m_day { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string m_title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string m_contents { get; set; } = null!;
}
