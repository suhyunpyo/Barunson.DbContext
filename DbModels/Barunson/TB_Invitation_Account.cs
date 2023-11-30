using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[PrimaryKey("Invitation_ID", "Sort", "Category")]
public partial class TB_Invitation_Account
{
    [Key]
    public int Invitation_ID { get; set; }

    [Key]
    public int Sort { get; set; }

    [Key]
    public int Category { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Send_Target_Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Send_Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bank_Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Account_Number { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Account_Holder { get; set; }

    [ForeignKey("Invitation_ID")]
    [InverseProperty("TB_Invitation_Account")]
    public virtual TB_Invitation Invitation { get; set; } = null!;
}
