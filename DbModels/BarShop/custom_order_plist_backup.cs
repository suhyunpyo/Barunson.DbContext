using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("id", Name = "IX_custom_order_plist_backup_id")]
public partial class custom_order_plist_backup
{
    public long id { get; set; }

    public int? sid { get; set; }

    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string print_type { get; set; } = null!;

    public int card_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? title { get; set; }

    public int? print_count { get; set; }

    [StringLength(4000)]
    public string? etc_comment { get; set; }

    [StringLength(200)]
    public string? etc_info_s { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? order_filename { get; set; }

    public short option_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotSet { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotPrint { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? env_zip { get; set; }

    [StringLength(600)]
    public string? env_addr { get; set; }

    [StringLength(400)]
    public string? env_addr_detail { get; set; }

    [StringLength(50)]
    public string? env_phone { get; set; }

    [StringLength(50)]
    public string? env_hphone { get; set; }

    [StringLength(50)]
    public string? env_person1_header { get; set; }

    [StringLength(50)]
    public string? env_person2_header { get; set; }

    [StringLength(100)]
    public string? env_person1 { get; set; }

    [StringLength(100)]
    public string? env_person2 { get; set; }

    [StringLength(50)]
    public string? env_person_Tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnv_person_tail { get; set; }

    [StringLength(100)]
    public string? env_person1_tail { get; set; }

    [StringLength(100)]
    public string? env_person2_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isZipBox { get; set; }

    [StringLength(50)]
    public string? recv_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPostMark { get; set; }

    [StringLength(50)]
    public string? postname { get; set; }

    public byte? pstatus { get; set; }

    public int? preview_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? imgFolder { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? imgName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? choan_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? print_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? print_admin_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? choanmerge_date { get; set; }

    public long? up_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isQrcode { get; set; }

    [StringLength(50)]
    public string? postname_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBasic { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? env_hphone2 { get; set; }

    public int? env_addr_type { get; set; }

    [StringLength(300)]
    public string? env_road_addr { get; set; }

    [StringLength(200)]
    public string? env_road_addr_detail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotPrint_Addr { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnvSpecialType { get; set; }
}
