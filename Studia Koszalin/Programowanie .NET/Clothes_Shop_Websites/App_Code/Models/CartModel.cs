using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
            db.Carts.Add(cart);
            db.SaveChanges();

            return "Zamówienie dodane do koszyka";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();

            //Fetch object from db
            Cart p = db.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;

            db.SaveChanges();
            return cart.DatePurchased + "zaktualizowano koszyk";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + "usunięto koszyk";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public List<Cart> GetOrdersInCart(string clientId)
    {
       Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
        List<Cart> orders = (from x in db.Carts
                             where x.ClientID == clientId
                             && x.IsInCart
                             orderby x.DatePurchased descending
                             select x).ToList();
        return orders;
    }

    public int GetAmountOfOrders(string clientId)
    {
        try
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
            int amount = (from x in db.Carts
                          where x.ClientID == clientId
                          && x.IsInCart
                          select x.Amount).Sum();

            return amount;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateQuantity(int id, int quantity)
    {
        Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
        Cart p = db.Carts.Find(id);
        p.Amount = quantity;

        db.SaveChanges();
    }

    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        Clothes_ShopEntities2 db = new Clothes_ShopEntities2();

        if (carts != null)
        {
            foreach (Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.CartID);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }
}