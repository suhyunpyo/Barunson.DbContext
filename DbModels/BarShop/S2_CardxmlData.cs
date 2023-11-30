using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardxmlData
{
    [Key]
    public int Card_SeqNum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Card_Code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Brand { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Gubun { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ImgSize { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Comment { get; set; }
}
