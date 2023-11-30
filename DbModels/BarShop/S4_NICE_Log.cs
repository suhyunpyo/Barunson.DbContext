using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// nice 인증 로그
/// </summary>
[Keyless]
public partial class S4_NICE_Log
{
    public int NIC_Idx { get; set; }

    [StringLength(50)]
    public string? NIC_REQ { get; set; }

    [StringLength(50)]
    public string? NIC_RES { get; set; }

    [StringLength(50)]
    public string? NIC_AUTH { get; set; }

    [StringLength(50)]
    public string? NIC_NAME { get; set; }

    [StringLength(50)]
    public string? NIC_BIRTHDATE { get; set; }

    [StringLength(50)]
    public string? NIC_GENDER { get; set; }

    [StringLength(50)]
    public string? NIC_NTL { get; set; }

    [StringLength(250)]
    public string? NIC_DI { get; set; }

    [StringLength(250)]
    public string? NIC_CI { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NIC_Regdate { get; set; }

    [StringLength(250)]
    public string? NIC_MSG { get; set; }

    [StringLength(50)]
    public string? NIC_RTN { get; set; }
}
