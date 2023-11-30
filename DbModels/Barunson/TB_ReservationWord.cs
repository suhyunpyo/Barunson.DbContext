using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 예약어
/// </summary>
public partial class TB_ReservationWord
{
    /// <summary>
    /// 예약어_ID
    /// </summary>
    [Key]
    public int ReserveWord_ID { get; set; }

    /// <summary>
    /// 예약어
    /// </summary>
    [StringLength(100)]
    public string? ReserveWord { get; set; }

    /// <summary>
    /// 맵핑필드
    /// </summary>
    [StringLength(100)]
    public string? MappingField { get; set; }

    /// <summary>
    /// 기본값
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? DefaultValue { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Mapping_YN { get; set; } = null!;

    public int Sort { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(15)]
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

    [StringLength(100)]
    [Unicode(false)]
    public string? Product_Category_Codes { get; set; }
}
