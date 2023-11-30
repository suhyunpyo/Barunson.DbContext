using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 위시리스트
/// </summary>
[Index("User_ID", Name = "IX_TB_Wish_List_userid")]
public partial class TB_Wish_List
{
    /// <summary>
    /// 찜_ID
    /// </summary>
    [Key]
    public int Wish_ID { get; set; }

    /// <summary>
    /// 사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string User_ID { get; set; } = null!;

    /// <summary>
    /// 상품_ID
    /// </summary>
    public int? Product_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }
}
