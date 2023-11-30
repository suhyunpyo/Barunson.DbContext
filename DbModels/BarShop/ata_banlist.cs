using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 비즈톡 스팸등록
/// </summary>
[PrimaryKey("service_type", "ban_seq")]
[Index("ban_type", "service_type", "ban_status_yn", Name = "idx_ata_banlist_1")]
[Index("content", Name = "idx_ata_banlist_2")]
public partial class ata_banlist
{
    /// <summary>
    /// 서비스 메시지 전송 타입(3-알림톡)
    /// </summary>
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string service_type { get; set; } = null!;

    [Key]
    public int ban_seq { get; set; }

    /// <summary>
    /// 스팸 차단 구분 R-수신 번호(recipient_num필드와 비교) , T-메시지 내용(content필드와 비교)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ban_type { get; set; } = null!;

    /// <summary>
    /// 스팸 문구
    /// </summary>
    [StringLength(45)]
    [Unicode(false)]
    public string content { get; set; } = null!;

    /// <summary>
    /// 스팸 문구 전송 여부 (Y:발송 N:발송안함)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string send_yn { get; set; } = null!;

    /// <summary>
    /// 전송 차단 여부(Y:차단, N:취소)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ban_status_yn { get; set; } = null!;

    /// <summary>
    /// 등록 시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? reg_user { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime update_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? update_user { get; set; }
}
