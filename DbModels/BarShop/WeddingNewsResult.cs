using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class WeddingNewsResult
{
    /// <summary>
    /// 글번호
    /// </summary>
    [Key]
    public int WeddingNewsIdx { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(150)]
    public string? Title { get; set; }

    /// <summary>
    /// 기사URL
    /// </summary>
    [StringLength(300)]
    public string? Url { get; set; }

    /// <summary>
    /// 반려사유타입 1:이미지불충분, 2:텍스트오류, 3:내용불충분, 4:기타
    /// </summary>
    [StringLength(1)]
    public string? RejectCommentType { get; set; }

    /// <summary>
    /// 반려사유
    /// </summary>
    [StringLength(300)]
    public string? RejectComment { get; set; }

    /// <summary>
    /// 반려횟수
    /// </summary>
    public int? RejectCount { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModDate { get; set; }

    /// <summary>
    /// 업체에서 전달받은 데이터
    /// </summary>
    public string? Content { get; set; }
}
