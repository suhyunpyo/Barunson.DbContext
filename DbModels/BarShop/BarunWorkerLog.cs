using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("LogTime", "FunctionName", Name = "IX_BarunWorkerLog_LogTime_FunctionName")]
public partial class BarunWorkerLog
{
    [Key]
    public int LogSeq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogTime { get; set; }

    [StringLength(50)]
    public string FunctionName { get; set; } = null!;

    [StringLength(50)]
    public string WorkerName { get; set; } = null!;

    public string? LogDetail { get; set; }
}
