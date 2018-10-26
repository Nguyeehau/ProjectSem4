using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Model.Abstract
{
    public class TableattributeCommon : ITableattributeCommon
    {

        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public string Metakeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
