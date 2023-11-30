using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_PROD
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? prod_name { get; set; }

    /// <summary>
    /// S:소프트커버,H:하드커버
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string cover_style { get; set; } = null!;

    public int prod_price { get; set; }

    public short cate_index { get; set; }

    public short? prod_page { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? prod_size { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? sample_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? disrate_type { get; set; }

    public short? fix_disrate { get; set; }

    /// <summary>
    /// 1:학술,2:포토아비즈
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? makecom_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? skin_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isDP { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isChgCover { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isChgSize { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isEpilog { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isProlog { get; set; } = null!;

    /// <summary>
    /// 단체앨범 판매여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isSaleGroup { get; set; }

    /// <summary>
    /// 기프트앨범
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isSaleGift { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSaleBlog { get; set; }

    public short? picture_num { get; set; }

    public int? sales_ranking { get; set; }

    [Column(TypeName = "text")]
    public string? prod_description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_xs { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_s { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_ms { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b9 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b10 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_m { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isTest { get; set; }
}
