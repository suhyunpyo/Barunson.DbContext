using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 원클릭샘플이벤트
/// </summary>
public partial class oneclick_sample
{
    [Key]
    public int oc_Sample_Seq { get; set; }

    /// <summary>
    /// 샘플그룹명
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? evt_nm { get; set; }

    public int Card_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Card_Code { get; set; } = null!;

    /// <summary>
    /// 사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Use_YN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Reg_Date { get; set; }
}
