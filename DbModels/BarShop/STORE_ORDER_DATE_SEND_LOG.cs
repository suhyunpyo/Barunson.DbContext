using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class STORE_ORDER_DATE_SEND_LOG
{
    [Key]
    public int Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    public int Uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Member_ID { get; set; } = null!;

    public byte Status_Seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Memo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string RefererURL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string IP { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string User_Agent { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Auto_Yn { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Reg_Date { get; set; }
}
