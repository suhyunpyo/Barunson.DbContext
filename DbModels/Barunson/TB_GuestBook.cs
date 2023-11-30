using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 방명록
/// </summary>
[Index("Invitation_ID", Name = "IX_TB_GuestBook_ID")]
public partial class TB_GuestBook
{
    /// <summary>
    /// 방명록_ID
    /// </summary>
    [Key]
    public int GuestBook_ID { get; set; }

    /// <summary>
    /// 초대장_ID
    /// </summary>
    public int Invitation_ID { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(100)]
    public string? Name { get; set; }

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Password { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    [StringLength(1000)]
    public string? Message { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Display_YN { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [ForeignKey("Invitation_ID")]
    [InverseProperty("TB_GuestBook")]
    public virtual TB_Invitation Invitation { get; set; } = null!;
}
