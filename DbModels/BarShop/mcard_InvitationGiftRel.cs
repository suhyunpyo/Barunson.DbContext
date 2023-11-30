using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("InvitationID", "GiftID")]
public partial class mcard_InvitationGiftRel
{
    [Key]
    public int InvitationID { get; set; }

    [Key]
    public int GiftID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    public byte ListOrder { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string SelectYN { get; set; } = null!;

    [ForeignKey("GiftID")]
    [InverseProperty("mcard_InvitationGiftRel")]
    public virtual mcard_Gift Gift { get; set; } = null!;

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_InvitationGiftRel")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
