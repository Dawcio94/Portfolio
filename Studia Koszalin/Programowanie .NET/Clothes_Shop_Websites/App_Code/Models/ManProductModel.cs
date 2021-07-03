using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ManProductModel
/// </summary>
public class ManProductModel
{

    public Product GetProduct(int id)
    {
        try
        {
            using (Clothes_ShopEntities2 db = new Clothes_ShopEntities2())
            {
                Product product = db.Products.Find(id);
                return product;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }



    public List<Product> GetProductsByType(int typeid,string sex)
    {
        try
        {
            using (Clothes_ShopEntities2 db = new Clothes_ShopEntities2())
            {
                List<Product> products = (from x in db.Products
                                          where x.TypeID == typeid && x.Sex==sex
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}