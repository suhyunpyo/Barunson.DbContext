using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 상품_이미지
/// </summary>
public partial class TB_Product_Image
{
    /// <summary>
    /// 이미지_ID
    /// </summary>
    [Key]
    public int Image_ID { get; set; }

    /// <summary>
    /// 상품_ID
    /// </summary>
    public int Product_ID { get; set; }

    /// <summary>
    /// 이미지_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Image_URL { get; set; }

    /// <summary>
    /// 이미지_유형_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Image_Type_Code { get; set; }

    /// <summary>
    /// 등록_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    /// <summary>
    /// 등록_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    /// <summary>
    /// 수정_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    /// <summary>
    /// 수정_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    /// <summary>
    /// 수정_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [ForeignKey("Product_ID")]
    [InverseProperty("TB_Product_Image")]
    public virtual TB_Product Product { get; set; } = null!;
}
