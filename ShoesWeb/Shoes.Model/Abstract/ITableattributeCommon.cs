using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Model.Abstract
{
    interface ITableattributeCommon
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        string UpdatedBy { get; set; }
        string Metakeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }

    }
}
