using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_TmpInvitationOption
{
    [Key]
    public int OptionID { get; set; }

    public int InvitationID { get; set; }

    [StringLength(20)]
    public string OptionItem { get; set; } = null!;

    [StringLength(100)]
    public string OptionValue { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegisterTime { get; set; }

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_TmpInvitationOption")]
    public virtual mcard_TmpInvitation Invitation { get; set; } = null!;
}
