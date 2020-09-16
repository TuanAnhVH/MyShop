using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace MyShop.Data.Infrastructure
{
    public class DbFactory: Disposable,IDbFactory
    {
		private MyShopDbContext dbContext;

		MyShopDbContext IDbFactory.Init()
		{
			return dbContext ?? (dbContext = new MyShopDbContext());
		}

		protected override void DisposeCore()
		{
			if (dbContext != null)
				dbContext.Dispose();
		}

      
    }
}
