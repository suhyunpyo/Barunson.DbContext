using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SendEmailMaster
{
    /// <summary>
    /// 패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-&gt; Customer 관련 첫번재 메일폼
    /// </summary>
    [Key]
    [StringLength(3)]
    public string EmailFormCode { get; set; } = null!;

    [StringLength(30)]
    public string SenderName { get; set; } = null!;

    [StringLength(100)]
    public string SenderEmailAddress { get; set; } = null!;

    [StringLength(100)]
    public string Title { get; set; } = null!;

    public bool UseYn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModDate { get; set; }

    /// <summary>
    /// ([이메일] - 신청자 메일 주소, [문의사항] - 문의사항내용 ) 등 콘텐트에 치환될 내용 설명(참고용)
    /// </summary>
    [StringLength(2000)]
    public string? ContentDescription { get; set; }

    /// <summary>
    /// 메일 본문 또는 본문 페이지 URL
    /// </summary>
    public string Contents { get; set; } = null!;

    [InverseProperty("EmailFormCodeNavigation")]
    public virtual ICollection<SendEmailRecipient> SendEmailRecipient { get; } = new List<SendEmailRecipient>();
}
