using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 아이콘
/// </summary>
public partial class TB_Icon
{
    /// <summary>
    /// 아이콘_ID
    /// </summary>
    [Key]
    public int Icon_ID { get; set; }

    /// <summary>
    /// 아이콘_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Icon_URL { get; set; }

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

    [InverseProperty("Icon")]
    public virtual ICollection<TB_Product_Icon> TB_Product_Icon { get; } = new List<TB_Product_Icon>();
}
