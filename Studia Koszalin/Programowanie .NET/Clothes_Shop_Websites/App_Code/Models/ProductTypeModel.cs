using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeModel
/// </summary>
public class ProductTypeModel
{
        public ProductType GetProductType(int id)
            {
        try
        {
            using (Clothes_ShopEntities2 db = new Clothes_ShopEntities2())
            {
                ProductType producttype = db.ProductTypes.Find(id);
                return producttype;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public List<ProductType> GetAllProductsType()
    {
        try
        {
            using (Clothes_ShopEntities2 db = new Clothes_ShopEntities2())
            {
                List<ProductType> productstype = (from x in db.ProductTypes
                                          select x).ToList();
                return productstype;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
