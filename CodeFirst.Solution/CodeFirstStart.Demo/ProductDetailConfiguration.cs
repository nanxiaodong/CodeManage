using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class ProductDetailConfiguration : EntityTypeConfiguration<ProductDetail>
    {
        public ProductDetailConfiguration()
        {
            //ProductDetail作为主类
            this.HasRequired(i => i.Product).WithRequiredPrincipal(i => i.ProductDetail);

            
        }
    }
}
