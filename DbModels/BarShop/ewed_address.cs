using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_address
{
    [Key]
    public int no { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string email { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string? hp { get; set; }

    public byte gcode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? birth_y { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? birth_m { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? birth_d { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? h_zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? h_zip2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? h_addr { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? h_addr_detail { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? h_phone { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? company { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? c_zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? c_zip2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? c_addr { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? c_addr_detail { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? c_phone { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? memo { get; set; }
}
