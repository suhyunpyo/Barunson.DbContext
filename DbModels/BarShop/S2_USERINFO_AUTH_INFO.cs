using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("DUPINFO", Name = "IDX_S2_USERINFO_AUTH_INFO_DUPINFO")]
public partial class S2_USERINFO_AUTH_INFO
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ENCODE_DATA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DUPINFO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AUTH_MODULE_TYPE { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? BIRTH_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GENDER { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NATIONAL_INFO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AUTH_DESC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
