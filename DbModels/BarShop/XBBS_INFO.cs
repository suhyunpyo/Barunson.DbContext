using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class XBBS_INFO
{
    [Key]
    public int XI_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string XI_TITLE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? XI_TITLE_IMG { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? XI_DESCRIPTION { get; set; }

    /// <summary>
    /// 0:공지사항게시판,1:자유게시판
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string XI_PUBLIC { get; set; } = null!;

    public int XI_ROWS { get; set; }

    public int XI_PAGES { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string XI_TMP_FILE { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [InverseProperty("XI_SEQNavigation")]
    public virtual ICollection<XBBS_ARTICLE> XBBS_ARTICLE { get; } = new List<XBBS_ARTICLE>();
}
