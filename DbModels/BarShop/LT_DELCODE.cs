using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// CJ 송장코드
/// </summary>
public partial class LT_DELCODE
{
    [Key]
    public int DELCODE_SEQ { get; set; }

    public long CODESEQ { get; set; }

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(12)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    /// <summary>
    /// 사용유무 (0:사용안함, 1:사용완료)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ISUSE { get; set; } = null!;

    public int? IS_USE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IMG_YN { get; set; }
}
