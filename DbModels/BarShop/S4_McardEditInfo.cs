using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일청첩장
/// </summary>
[Keyless]
public partial class S4_McardEditInfo
{
    public int Order_Seq { get; set; }

    public int? SkinIndex { get; set; }

    public int? TitleIndex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TitleX1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TitleY1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TitleAlpha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TitleColor { get; set; }

    public int? ManIndex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManX1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManY1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManX2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManY2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ManTel { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? GirlTel { get; set; }

    public int? GirlIndex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GirlX1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GirlY1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GirlX2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GirlY2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MoreX1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MoreY1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MoreX2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MoreY2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldW { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldH { get; set; }

    [Column(TypeName = "text")]
    public string? TextFieldText { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldColor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TextFieldBgAlpha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Image_Id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }
}
