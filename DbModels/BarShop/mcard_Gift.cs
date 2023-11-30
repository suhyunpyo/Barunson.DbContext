using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class mcard_Gift
{
    [Key]
    public int GiftID { get; set; }

    [StringLength(30)]
    public string GiftName { get; set; } = null!;

    public int GiftPrice { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string GiftURL { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string GiftImageURL { get; set; } = null!;

    public byte GiftOrder { get; set; }

    [InverseProperty("Gift")]
    public virtual ICollection<mcard_InvitationGiftRel> mcard_InvitationGiftRel { get; } = new List<mcard_InvitationGiftRel>();

    [InverseProperty("Gift")]
    public virtual ICollection<mcard_TmpInvitationGiftRel> mcard_TmpInvitationGiftRel { get; } = new List<mcard_TmpInvitationGiftRel>();
}
