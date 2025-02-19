﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxYyyAwardItem
    {
        public int Id { get; set; }
        public int? ActId { get; set; }
        public string JxName { get; set; }
        public string JpName { get; set; }
        public int? JpNum { get; set; }
        public int? JpRealNum { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? JiaoduMin { get; set; }
        public double? JiaoduMax { get; set; }
    }
}
