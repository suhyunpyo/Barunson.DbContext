using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class WeddingNewsTemplate
{
    /// <summary>
    /// 템플릿번호
    /// </summary>
    [Key]
    public int TemplateIdx { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(150)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// 추가설명
    /// </summary>
    [StringLength(300)]
    public string AdditionDescription { get; set; } = null!;

    /// <summary>
    /// 추가선택사항
    /// </summary>
    [StringLength(300)]
    public string? AdditionChoice { get; set; }

    /// <summary>
    /// 신랑이름여부
    /// </summary>
    public bool? GroomNameYn { get; set; }

    /// <summary>
    /// 신랑나이여부
    /// </summary>
    public bool? GroomAgeYn { get; set; }

    /// <summary>
    /// 신부이름여부
    /// </summary>
    public bool? BrideNameYn { get; set; }

    /// <summary>
    /// 신부나이여부
    /// </summary>
    public bool? BrideAgeYn { get; set; }

    /// <summary>
    /// 예식날짜여부
    /// </summary>
    public bool? WeddDateYn { get; set; }

    /// <summary>
    /// 예식시간여부
    /// </summary>
    public bool? WeddingTimeYn { get; set; }

    /// <summary>
    /// 예식장정보여부
    /// </summary>
    public bool? WeddNameYn { get; set; }

    /// <summary>
    /// 층홀실여부
    /// </summary>
    public bool? WeddPlaceYn { get; set; }

    /// <summary>
    /// 신랑부여부
    /// </summary>
    public bool? GroomFatherYn { get; set; }

    /// <summary>
    /// 신랑모여부
    /// </summary>
    public bool? GroomMotherYn { get; set; }

    /// <summary>
    /// 신랑서열여부
    /// </summary>
    public bool? GroomRankYn { get; set; }

    /// <summary>
    /// 신부부여부
    /// </summary>
    public bool? BrideFatherYn { get; set; }

    /// <summary>
    /// 신부모여부
    /// </summary>
    public bool? BrideMotherYn { get; set; }

    /// <summary>
    /// 신부서열여부
    /// </summary>
    public bool? BrideRankYn { get; set; }

    /// <summary>
    /// 부직업여부
    /// </summary>
    public bool? FatherJobYn { get; set; }

    /// <summary>
    /// 회사여부
    /// </summary>
    public bool? CompanyYn { get; set; }

    /// <summary>
    /// 직급여부
    /// </summary>
    public bool? PositionYn { get; set; }

    /// <summary>
    /// 신랑이름선택여부
    /// </summary>
    public bool? GroomNameRadioYn { get; set; }

    /// <summary>
    /// 신부이름선택여부
    /// </summary>
    public bool? BrideNameRadioYn { get; set; }

    /// <summary>
    /// 신랑부선택여부
    /// </summary>
    public bool? GroomFatherRadioYn { get; set; }

    /// <summary>
    /// 신부부선택여부
    /// </summary>
    public bool? BrideFatherRadioYn { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    public bool? UseYn { get; set; }

    /// <summary>
    /// 순서(노출순서)
    /// </summary>
    public int Sort { get; set; }

    /// <summary>
    /// 등록자
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string AdminId { get; set; } = null!;

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? ModDate { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    public string Contents { get; set; } = null!;
}
