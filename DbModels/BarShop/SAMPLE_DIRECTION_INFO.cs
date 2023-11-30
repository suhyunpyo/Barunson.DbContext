using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SAMPLE_DIRECTION_INFO
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SITE_GUBUN { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? SITE_IMAGE_URL { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? SITE_THUMB_IMAGE_URL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_TITLE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT4 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT5 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BENEFIT_CONTENT6 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ORDER_CONTENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGIST_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? REGIST_UID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATE_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UPDATE_UID { get; set; }
}
