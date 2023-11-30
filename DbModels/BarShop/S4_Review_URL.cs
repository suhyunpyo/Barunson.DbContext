using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Review_URL
{
    [Key]
    public int Review_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Review_Group { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Company_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? User_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? User_Name { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CellPhone { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Review_Url { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Review_Url2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Review_Date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Evaluator { get; set; }

    public short? Evaluate_Tag { get; set; }

    [Column(TypeName = "text")]
    public string? Evaluate_Content { get; set; }

    [Column(TypeName = "text")]
    public string? Evaluate_Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Evaluate_Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Send_Date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? View_Flag { get; set; }
}
