using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class HeadCol_TEMP
{
    public int? Card_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Card_Code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CardBrand { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BHands { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TheCard { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CardDiscount { get; set; }

    [Column(TypeName = "numeric(28, 8)")]
    public decimal? Card_Price { get; set; }

    [Column(TypeName = "numeric(28, 8)")]
    public decimal? CardSet_Price { get; set; }

    public int? White { get; set; }

    public int? Cream { get; set; }

    public int? Gold { get; set; }

    public int? Silver { get; set; }

    public int? Pink { get; set; }

    public int? Purple { get; set; }

    public int? Blue { get; set; }

    public int? Floral { get; set; }

    public int? Multicolor { get; set; }

    public int? 리본띠지 { get; set; }

    public int? 꽃식물 { get; set; }

    public int? 나비새 { get; set; }

    public int? 하트 { get; set; }

    public int? 오브제큐빅등 { get; set; }

    public int? 홀로그램 { get; set; }

    public int? 레이커컷팅 { get; set; }

    public int? 커스텀마이징 { get; set; }

    public int? 포토 { get; set; }

    public int? 전통적인디자인 { get; set; }

    public int? 심플모던 { get; set; }

    public int? 여성사랑스러운 { get; set; }

    public int? 럭셔리우아한 { get; set; }

    public int? 세련되고감각적인 { get; set; }
}
