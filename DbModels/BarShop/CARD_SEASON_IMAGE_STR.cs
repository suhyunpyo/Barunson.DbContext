using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// CARD_SEASON_IMAGE_STR
/// </summary>
public partial class CARD_SEASON_IMAGE_STR
{
    [Key]
    public int card_seq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b1_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b2_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b3_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b4_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b5_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b6_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b7_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b8_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b9_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b10_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b11_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b12_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b13_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b14_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_img_b15_str { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
