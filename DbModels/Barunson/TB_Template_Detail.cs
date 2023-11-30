using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 템플릿 상세
/// </summary>
public partial class TB_Template_Detail
{
    /// <summary>
    /// 템플릿_ID
    /// </summary>
    [Key]
    public int Template_ID { get; set; }

    /// <summary>
    /// 인사말
    /// </summary>
    [StringLength(1000)]
    public string? Greetings { get; set; }

    /// <summary>
    /// 신랑_명
    /// </summary>
    [StringLength(100)]
    public string Groom_Name { get; set; } = null!;

    /// <summary>
    /// 신랑_영문명
    /// </summary>
    [StringLength(100)]
    public string? Groom_EngName { get; set; }

    /// <summary>
    /// 신랑_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Groom_Phone { get; set; }

    /// <summary>
    /// 신부_명
    /// </summary>
    [StringLength(100)]
    public string Bride_Name { get; set; } = null!;

    /// <summary>
    /// 신부_영문명
    /// </summary>
    [StringLength(100)]
    public string? Bride_EngName { get; set; }

    /// <summary>
    /// 신부_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Bride_Phone { get; set; }

    /// <summary>
    /// 신랑_혼주1_명칭
    /// </summary>
    [StringLength(100)]
    public string? Groom_Parents1_Name { get; set; }

    /// <summary>
    /// 신랑_혼주1_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Groom_Parents1_Phone { get; set; }

    /// <summary>
    /// 신랑_혼주2_명칭
    /// </summary>
    [StringLength(100)]
    public string? Groom_Parents2_Name { get; set; }

    /// <summary>
    /// 신랑_혼주2_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Groom_Parents2_Phone { get; set; }

    /// <summary>
    /// 신부_혼주1_명칭
    /// </summary>
    [StringLength(100)]
    public string? Bride_Parents1_Name { get; set; }

    /// <summary>
    /// 신부_혼주1_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Bride_Parents1_Phone { get; set; }

    /// <summary>
    /// 신부_혼주2_명칭
    /// </summary>
    [StringLength(100)]
    public string? Bride_Parents2_Name { get; set; }

    /// <summary>
    /// 신부_혼주2_전화
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Bride_Parents2_Phone { get; set; }

    /// <summary>
    /// 예식일자
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string WeddingDate { get; set; } = null!;

    /// <summary>
    /// 예식시분
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string WeddingHHmm { get; set; } = null!;

    /// <summary>
    /// 시간_구분_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Time_Type_Code { get; set; } = null!;

    /// <summary>
    /// 시간_구분_영문_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Time_Type_Eng_YN { get; set; }

    /// <summary>
    /// 예식년
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? WeddingYY { get; set; }

    /// <summary>
    /// 예식월
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? WeddingMM { get; set; }

    /// <summary>
    /// 예식일
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? WeddingDD { get; set; }

    /// <summary>
    /// 예식요일
    /// </summary>
    [StringLength(100)]
    public string? WeddingWeek { get; set; }

    /// <summary>
    /// 예식요일_영어_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? WeddingWeek_Eng_YN { get; set; }

    /// <summary>
    /// 예식시간
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? WeddingHour { get; set; }

    /// <summary>
    /// 예식분
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? WeddingMin { get; set; }

    /// <summary>
    /// 예식장_명
    /// </summary>
    [StringLength(100)]
    public string Weddinghall_Name { get; set; } = null!;

    /// <summary>
    /// 층홀실
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? WeddingHallDetail { get; set; }

    /// <summary>
    /// 예식장_주소1
    /// </summary>
    [StringLength(500)]
    public string? Weddinghall_Address { get; set; }

    /// <summary>
    /// 예식장_연락처
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Weddinghall_PhoneNumber { get; set; }

    /// <summary>
    /// 기타_버스_안내
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Etc_Bus_Information { get; set; }

    /// <summary>
    /// 기타_자가용_안내
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Etc_Car_Information { get; set; }

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

    [StringLength(100)]
    public string? Baby_Name { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Baby_Birthday { get; set; }

    public string? RepeatData { get; set; }

    [ForeignKey("Template_ID")]
    [InverseProperty("TB_Template_Detail")]
    public virtual TB_Template Template { get; set; } = null!;
}
