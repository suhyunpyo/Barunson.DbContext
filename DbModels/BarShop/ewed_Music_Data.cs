using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Music_Data
{
    [Key]
    public int seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string m_title { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string m_file { get; set; } = null!;

    public int use_cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }
}
