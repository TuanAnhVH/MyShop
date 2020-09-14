using System;

namespace MyShop.Model.Abstracts
{
    public interface IAuditable
    {
        DateTime CreatedDate { set; get; }
        String CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdatedBy { set; get; }
    }
}
