using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TiaraBestRanking
{
    public int? Card_Seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    public short? Cnt { get; set; }

    /// <summary>
    /// MB:월간베스트
    /// WB:주간베스트
    /// SB:샘플베스트
    /// SF:여성베스트
    /// SM:남성베스트
    /// AA:20대베스트
    /// AB:30대베스트
    /// AC:40대베스트
    /// AD:50대베스트
    /// PA:300~600원대
    /// PB:700~1000원대
    /// PC:1100~1400원대
    /// PD:1500원이상
    /// BA:티아라,유사미디자인스
    /// BB:바른손카드
    /// BC:신상품
    /// BD:위시메이드
    /// BE:해피카드
    /// BF:스튜디오진,벨라피오레
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? Gubun { get; set; }
}
