using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 초대장_수수료
/// </summary>
[Index("Tax_ID", Name = "IX_TB_InvitationTax_Tax_ID")]
public partial class TB_Invitation_Tax
{
    /// <summary>
    /// 초대장_ID
    /// </summary>
    [Key]
    public int Invitation_ID { get; set; }

    /// <summary>
    /// 수수료_ID
    /// </summary>
    public int? Tax_ID { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Remit> TB_Remit { get; } = new List<TB_Remit>();

    [ForeignKey("Tax_ID")]
    [InverseProperty("TB_Invitation_Tax")]
    public virtual TB_Tax? Tax { get; set; }
}
