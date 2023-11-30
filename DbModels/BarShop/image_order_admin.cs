using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이미지_주문_관리자
/// </summary>
public partial class image_order_admin
{
    /// <summary>
    /// 관리자_ID
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? admin_pwd { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(50)]
    public string? admin_name { get; set; }

    /// <summary>
    /// 롤
    /// </summary>
    public byte? admin_role { get; set; }
}
