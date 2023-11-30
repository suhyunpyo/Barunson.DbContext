using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop
{
    /// <summary>
    /// 리뷰 수 통계
    /// </summary>
    public partial class Custom_Order_Review_Count
    {
       
        public int CompaySeq { get; set; }
       
        public int CardSeq { get; set; }
       
        [Column(TypeName = "smalldatetime")]
        public DateTime SumDate { get; set; }

        /// <summary>
        /// 상품 평
        /// </summary>
        public int OrderReviewCount { get; set; }

        /// <summary>
        /// 샘플 후기, 카드 포함 전체
        /// </summary>
        public int SampleReviewCount { get; set; }
        /// <summary>
        /// 샘플 후기, 적용카드만
        /// </summary>
        public int RealSampleReviewCount { get; set; }

        public int? OrderScore { get; set; }
        public int? SampleScore { get; set; }
        public int? RealSampleScore { get; set; }


    }
}
