using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class MCARD_IMAGE_DELETE
{
    /// <summary>
    /// 삭제ID(F)-MCARD_INVITATION.INVITATIONID
    /// </summary>
    public int? INVITATIONID { get; set; }

    /// <summary>
    /// 이미지삭제일자
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DELETE_DATE { get; set; }
}
