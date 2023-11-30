using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 메뉴 관리
/// </summary>
public partial class INTEGRATION_ADMIN_MENU
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string MENU_SEQ { get; set; } = null!;

    [StringLength(50)]
    public string MENU_TITLE { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? PMENU_SEQ { get; set; }

    public int DEPTH { get; set; }

    public int SORT_NUM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string FOLDER_YORN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PUBLIC_YORN { get; set; } = null!;

    [StringLength(200)]
    public string LINK { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(50)]
    public string? FONT_AWESOME { get; set; }
}
