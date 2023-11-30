using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 공통_코드_그룹
/// </summary>
public partial class TB_Common_Code_Group
{
    /// <summary>
    /// 코드_그룹
    /// </summary>
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string Code_Group { get; set; } = null!;

    /// <summary>
    /// 그룹_명
    /// </summary>
    [StringLength(100)]
    public string? Group_Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [InverseProperty("Code_GroupNavigation")]
    public virtual ICollection<TB_Common_Code> TB_Common_Code { get; } = new List<TB_Common_Code>();
}
