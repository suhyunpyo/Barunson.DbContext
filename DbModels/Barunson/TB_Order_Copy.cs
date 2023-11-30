using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class TB_Order_Copy
{
    public int Order_ID { get; set; }

    public int? Previous_Order_ID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Order_Code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string User_ID { get; set; } = null!;

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CellPhone_Number { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public int Order_Price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Payment_Method_Code { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PG_ID { get; set; }

    public int? Coupon_Price { get; set; }

    public int? Payment_Price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Payment_Status_Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Order_Status_Code { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? Card_Installment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CashReceipt_Publish_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Noint_YN { get; set; }

    [StringLength(100)]
    public string? Finance_Auth_Number { get; set; }

    [StringLength(100)]
    public string? Finance_Name { get; set; }

    [StringLength(50)]
    public string? Payer_Name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Escrow_YN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Account_Number { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Trading_Number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Order_DateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cancel_DateTime { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Cancel_Time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Deposit_DeadLine_DateTime { get; set; }

    [StringLength(50)]
    public string? Order_Path { get; set; }

    [StringLength(50)]
    public string? Payment_Path { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Payment_DateTime { get; set; }
}
