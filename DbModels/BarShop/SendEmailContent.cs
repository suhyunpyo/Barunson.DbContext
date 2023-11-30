using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("SendYn", Name = "IX_SendEmailContent_SendYn")]
public partial class SendEmailContent
{
    [Key]
    public int ContentId { get; set; }

    /// <summary>
    /// 패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-&gt; Customer 관련 첫번재 메일폼
    /// </summary>
    [StringLength(3)]
    public string EmailFormCode { get; set; } = null!;

    /// <summary>
    /// 기본값: false, 내용 수정시 false 변경
    /// </summary>
    public bool SendYn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    /// <summary>
    /// 추가 수신 대상이 있을 경우
    /// </summary>
    [StringLength(30)]
    public string? ToName { get; set; }

    /// <summary>
    /// 추가 수신 대상이 있을 경우
    /// </summary>
    [StringLength(100)]
    public string? ToEmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModDate { get; set; }

    [InverseProperty("Content")]
    public virtual ICollection<SendEmailContentItem> SendEmailContentItem { get; } = new List<SendEmailContentItem>();
}
