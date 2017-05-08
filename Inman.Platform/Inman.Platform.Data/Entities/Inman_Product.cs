using Inman.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Platform.Data.Entities
{
    public class Inman_Product : BaseEntity
    {
        public virtual string ProductSN { get; set; }
        public virtual int? ColorID { get; set; }
        public virtual int? GoodsId { get; set; }
        public virtual string PicturePath { get; set; }
        public virtual string Remark { get; set; }
        public virtual bool IsUpload { get; set; }
        public virtual DateTime? UploadDate { get; set; }
      
    }
}
