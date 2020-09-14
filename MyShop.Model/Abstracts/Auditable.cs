using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Abstracts
{
    public abstract class Auditable
    {
        public DateTime CreatedDate { set; get; }

        [MaxLength(256)]
        public String CreatedBy { set; get; }
        public  DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaTitle { set; get; }
        public bool Status { set; get; }
    }
}
