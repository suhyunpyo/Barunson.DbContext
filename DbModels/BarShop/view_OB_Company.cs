using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_OB_Company
{
    public int COMPANY_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? JAEHU_KIND { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JUMUN_TYPE { get; set; }

    public int COMPANY_UPPER_SEQ { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string COMPANY_NAME { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? COMPANY_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGIST_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IMG_DIR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string LOGIN_ID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PASSWD { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? BOSS_NM { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BOSS_TEL_NO { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UP_TAE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string FAX_NO { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? KIND { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string E_MAIL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ZIP_CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string FRONT_ADDR { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BACK_ADDR { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MNG_NM { get; set; } = null!;

    [StringLength(120)]
    [Unicode(false)]
    public string MNG_E_MAIL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MNG_TEL_NO { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MNG_HP_NO { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MNG_ZIP_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MNG_ADDRESS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MNG_ADDR_DETAIL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ACC_NM { get; set; } = null!;

    [StringLength(120)]
    [Unicode(false)]
    public string ACC_E_MAIL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ACC_TEL_NO { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ACC_HP_NO { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CORP_EXP { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? BANK_NM { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ACCOUNT_NO { get; set; }

    public short? SUPPLY_DISRATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string REG_ID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CHG_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CHG_DT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ONOFF { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? INFO_TMP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? INFO_TMP2 { get; set; }

    public short? ewed_val { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ERP_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UP_TAE_STR { get; set; }

    public byte PRICE_GUBUN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SASIK_GUBUN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ERP_Dept { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ERP_TaxType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ERP_PartCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ERP_StaffCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ERP_CostCode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ERP_PriceLevel { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ERP_PGcheck { get; set; }
}
