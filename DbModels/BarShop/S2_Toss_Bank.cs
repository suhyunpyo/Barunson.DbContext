using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장 Toss은행코드
/// </summary>
public partial class S2_Toss_Bank
{
    [Key]
    public int SEQ { get; set; }

    /// <summary>
    /// 은행코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string BANK_CODE { get; set; } = null!;

    /// <summary>
    /// 은행명
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string BANK_NAME { get; set; } = null!;

    /// <summary>
    /// 사용유무
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string USE_YN { get; set; } = null!;
}
