using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class WeddingNews
{
    /// <summary>
    /// 글번호
    /// </summary>
    [Key]
    public int WeddingNewsIdx { get; set; }

    /// <summary>
    /// 템플릿번호
    /// </summary>
    public int TemplateIdx { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    public int OrderSeq { get; set; }

    /// <summary>
    /// 기사상태 W:작성중, I:기사전송, N:반려,  U: 수정접수, Y:완료 
    /// </summary>
    [StringLength(1)]
    public string Status { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [StringLength(150)]
    public string Title { get; set; } = null!;

    public int GroomAge { get; set; }

    public int BrideAge { get; set; }

    [StringLength(30)]
    public string? FatherJob { get; set; }

    [StringLength(50)]
    public string? Company { get; set; }

    [StringLength(30)]
    public string? Position { get; set; }

    /// <summary>
    /// 1:직접등록 0:제공이미지
    /// </summary>
    public int? ImgMode { get; set; }

    [StringLength(50)]
    public string? StudioName { get; set; }

    [StringLength(100)]
    public string ImgName { get; set; } = null!;

    [StringLength(100)]
    public string UpImgName { get; set; } = null!;

    [StringLength(2)]
    public string Mode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModDate { get; set; }

    public string Content { get; set; } = null!;

    [StringLength(20)]
    public string? RadioYnText { get; set; }

    /// <summary>
    /// 관리자메모
    /// </summary>
    [StringLength(200)]
    public string? AdminMemo { get; set; }
}
