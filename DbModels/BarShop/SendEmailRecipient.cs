using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("EmailFormCode", "Sort")]
public partial class SendEmailRecipient
{
    /// <summary>
    /// 패턴정의: 영문 대문자 1자리+숫자 2자리코드  ex)C01-&gt; Customer 관련 첫번재 메일폼
    /// </summary>
    [Key]
    [StringLength(3)]
    public string EmailFormCode { get; set; } = null!;

    [Key]
    public int Sort { get; set; }

    [StringLength(30)]
    public string ToName { get; set; } = null!;

    [StringLength(100)]
    public string ToEmailAddress { get; set; } = null!;

    public bool UserYn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModDate { get; set; }

    [ForeignKey("EmailFormCode")]
    [InverseProperty("SendEmailRecipient")]
    public virtual SendEmailMaster EmailFormCodeNavigation { get; set; } = null!;
}
