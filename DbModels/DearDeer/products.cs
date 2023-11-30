using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 상품관리
/// </summary>
[Index("code", Name = "code")]
[Index("product_label", Name = "product_label")]
[MySqlCollation("utf8_unicode_ci")]
public partial class products
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    [StringLength(100)]
    public string name { get; set; } = null!;

    [StringLength(20)]
    public string code { get; set; } = null!;

    [StringLength(100)]
    public string product_label { get; set; } = null!;

    [StringLength(20)]
    public string type { get; set; } = null!;

    [StringLength(20)]
    public string? designer { get; set; }

    /// <summary>
    /// 샘플 발송 횟수
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sample_count { get; set; }

    /// <summary>
    /// 주문 횟수
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_count { get; set; }

    /// <summary>
    /// 300매 기준 금액
    /// </summary>
    [Precision(9, 2)]
    public decimal? default_price { get; set; }

    /// <summary>
    /// T:첫주문무료/F:사용안함
    /// </summary>
    [StringLength(1)]
    public string first_order_free { get; set; } = null!;

    /// <summary>
    /// 판매가
    /// </summary>
    [Precision(9, 2)]
    public decimal price { get; set; }

    /// <summary>
    /// 공급가
    /// </summary>
    [Precision(9, 2)]
    public decimal sale { get; set; }

    /// <summary>
    /// 할인가
    /// </summary>
    [Precision(9, 2)]
    public decimal sale_price { get; set; }

    /// <summary>
    /// 텍스
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte taxable { get; set; }

    [Column(TypeName = "int(11)")]
    public int inventory { get; set; }

    /// <summary>
    /// 재고수량 표시 하기- 0: 사용안함, 1: 사용함
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte use_inventory { get; set; }

    /// <summary>
    /// 금일판매량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int today_sales { get; set; }

    /// <summary>
    /// 금일판매량 표시 하기- 0: 사용안함, 1: 사용함
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte use_today_sales { get; set; }

    /// <summary>
    /// badge type
    /// </summary>
    [StringLength(50)]
    public string? badge { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_new { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_hit { get; set; }

    /// <summary>
    /// MD추천(null:사용 안함 / 그외:sort_order)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? best_md { get; set; }

    /// <summary>
    /// 주간베스트(null:사용 안함 / 그외:sort_order)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? best_monthly { get; set; }

    /// <summary>
    /// 후기베스트(null:사용 안함 / 그외:sort_order)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? best_review { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_recommend { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_discount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_monday_sale { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte use_sale { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte use_option { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte use_category { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte use_sample_variable { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte has_image { get; set; }

    /// <summary>
    /// 샘플판매상태
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? use_sale_sample { get; set; }

    /// <summary>
    /// 인쇄 상태
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? is_printed { get; set; }

    /// <summary>
    /// 봉투인쇄 (E:일반봉투/S:스페셜봉투)
    /// </summary>
    [StringLength(1)]
    public string env_print_type { get; set; } = null!;

    /// <summary>
    /// 수량옵션 타입
    /// </summary>
    [StringLength(10)]
    public string? qty_type { get; set; }

    [StringLength(255)]
    public string? summary { get; set; }

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [Column(TypeName = "text")]
    public string? mobile_contents { get; set; }

    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [StringLength(100)]
    public string? represent_image { get; set; }

    /// <summary>
    /// 인쇄하는 곳이지: red or barunson
    /// </summary>
    [StringLength(10)]
    public string printing_company { get; set; } = null!;

    /// <summary>
    /// T:화면표시, F:화면표시안함
    /// </summary>
    [StringLength(1)]
    public string is_display { get; set; } = null!;

    /// <summary>
    /// 판매 불가 상태 메세지
    /// </summary>
    [Column(TypeName = "text")]
    public string? warning_desc { get; set; }

    [StringLength(1)]
    public string? has_after_step { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "double(8,2)")]
    public double? scale_x { get; set; }

    [Column(TypeName = "double(8,2)")]
    public double? scale_y { get; set; }

    /// <summary>
    /// 연관상품 사용할것이니?
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_relation { get; set; }

    [Column(TypeName = "smallint(6)")]
    public short? discount_rate { get; set; }

    [StringLength(1000)]
    public string? discount_comment { get; set; }

    /// <summary>
    /// Y:회원가입무료/N:사용안함
    /// </summary>
    [StringLength(1)]
    public string join_order_free { get; set; } = null!;

    /// <summary>
    /// 모바일뱃지셋트사용/사용안함
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_mcardset { get; set; }

    /// <summary>
    /// 봉투삽입 서비스
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_envinsert { get; set; }

    /// <summary>
    /// 속지삽입 서비스
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_inpaper { get; set; }

    /// <summary>
    /// 부속부착 서비스
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_handmade { get; set; }

    /// <summary>
    /// 초특급제작
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_special { get; set; }

    /// <summary>
    /// 주문단위(1:장,2:개,3:매,4:SET,5:BOX)
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? unit_type { get; set; }

    /// <summary>
    /// 단위당 수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? unit_value { get; set; }

    [InverseProperty("product")]
    public virtual ICollection<products_images> products_images { get; } = new List<products_images>();
}
