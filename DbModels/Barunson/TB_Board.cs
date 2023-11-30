using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 게시판
/// </summary>
public partial class TB_Board
{
    /// <summary>
    /// 게시판_ID
    /// </summary>
    [Key]
    public int Board_ID { get; set; }

    /// <summary>
    /// N - 공지사항
    /// 
    /// F - FAQ
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Board_Category { get; set; }

    /// <summary>
    /// 상단고정_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Top_YN { get; set; }

    /// <summary>
    /// 노출_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Display_YN { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Title { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Content { get; set; }

    /// <summary>
    /// 조회수
    /// </summary>
    public int? Hits { get; set; }

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
}
