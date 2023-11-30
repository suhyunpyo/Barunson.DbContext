using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardTechnic
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    /// <summary>
    /// 테크닉 이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string technic_name { get; set; } = null!;

    /// <summary>
    /// 테크닉 설명
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? technic_comment { get; set; }

    /// <summary>
    /// 테크닉 참고이미지
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? technic_image { get; set; }
}
