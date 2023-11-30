using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SAMSUNG_DELIVERY
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string branch_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? send_name { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? send_zip { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? send_Addr1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? send_addr2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? recv_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? recv_phone { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? recv_zip { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? recv_addr1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? recv_addr2 { get; set; }

    public byte? greeting_type { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
