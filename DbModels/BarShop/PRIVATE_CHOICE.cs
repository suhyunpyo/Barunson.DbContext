using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("SALES_GUBUN", "ORDER_TYPE", "CARD_SEQ", "MEMBER_ID")]
public partial class PRIVATE_CHOICE
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string ORDER_TYPE { get; set; } = null!;

    [Key]
    public int CARD_SEQ { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MEMBER_ID { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime REGDATE { get; set; }
}
