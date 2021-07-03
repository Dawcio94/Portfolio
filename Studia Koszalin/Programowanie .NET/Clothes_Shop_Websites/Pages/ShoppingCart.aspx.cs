using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Check if user is logged in
        string userId = User.Identity.GetUserName();

        //Display all items in user's cart.
        GetPurchasesInCart(userId);
    }

    protected void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        var cartModel = new CartModel();
        cartModel.DeleteCart(cartId);

        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Get ID of product that has had its quantity dropdownlist changed.
        DropDownList selectedList = (DropDownList)sender;
        int cartId = Convert.ToInt32(selectedList.ID);
        int quantity = Convert.ToInt32(selectedList.SelectedValue);

        //Update purchase with new quantity and refresh page
        CartModel cartModel = new CartModel();
        cartModel.UpdateQuantity(cartId, quantity);
        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

    private void GetPurchasesInCart(string userId)
    {
        CartModel cartModel = new CartModel();
        double subTotal = 0;

        //Get all purchases for current user and display in table
        List<Cart> purchaseList = cartModel.GetOrdersInCart(userId);
        CreateShopTable(purchaseList, out subTotal);

        //Add totals to webpage
        double vat = subTotal * 0.23;
        double totalAmount = subTotal + 15 + vat;

        litTotal.Text = "PLN " + subTotal;
        litVat.Text = "PLN " + vat;
        litTotalAmount.Text = "PLN " + totalAmount;

        
    }

    private void CreateShopTable(IEnumerable<Cart> carts, out double subTotal)
    {
        subTotal = new double();
        ManProductModel model = new ManProductModel();

        foreach (Cart cart in carts)
        {
            //Create HTML elements and fill values with database data
            Product product = model.GetProduct(cart.ProductID);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/{0}", product.Image),
                PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.ProductID)
            };

            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.ProductID),
                Text = "Delete Item",
                ID = "del" + cart.CartID,
            };

            lnkDelete.Click += Delete_Item;

            //Fill amount list with numbers 1-20
            int[] amount = Enumerable.Range(1, 20).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.CartID.ToString()
            };
            ddlAmount.DataBind();
            ddlAmount.SelectedValue = cart.Amount.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

            //Create table to hold shopping cart details
            Table table = new Table { CssClass = "CartTable" };
            TableRow row1 = new TableRow();
            TableRow row2 = new TableRow();

            TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell cell1_2 = new TableCell
            {
                Text = string.Format("<h4>{0}</h4><br />{1}<br/>W koszyku",
                product.Name, "Numer artykułu:" + product.ProductID),
                HorizontalAlign = HorizontalAlign.Left,
                Width = 350,
            };
            TableCell cell1_3 = new TableCell { Text = "Cena za sztukę<hr/>" };
            TableCell cell1_4 = new TableCell { Text = "Ilość<hr/>" };
            TableCell cell1_5 = new TableCell { Text = "Kwota<hr/>" };
            TableCell cell1_6 = new TableCell();

            TableCell cell2_1 = new TableCell();
            TableCell cell2_2 = new TableCell { Text = "PLN " + product.Price };
            TableCell cell2_3 = new TableCell();
            TableCell cell2_4 = new TableCell { Text = "PLN " + Math.Round(((Convert.ToDouble(cart.Amount) * Convert.ToDouble(product.Price))),2) };
            TableCell cell2_5 = new TableCell();

            

            //Set custom controls
            cell1_1.Controls.Add(btnImage);
            cell1_6.Controls.Add(lnkDelete);
            cell2_3.Controls.Add(ddlAmount);

            //Add rows & cells to table
            row1.Cells.Add(cell1_1);
            row1.Cells.Add(cell1_2);
            row1.Cells.Add(cell1_3);
            row1.Cells.Add(cell1_4);
            row1.Cells.Add(cell1_5);
            row1.Cells.Add(cell1_6);

            row2.Cells.Add(cell2_1);
            row2.Cells.Add(cell2_2);
            row2.Cells.Add(cell2_3);
            row2.Cells.Add(cell2_4);
            row2.Cells.Add(cell2_5);
            table.Rows.Add(row1);
            table.Rows.Add(row2);
            pnlShoppingCart.Controls.Add(table);

            //Add total of current purchased item to subtotal
            subTotal += ((Convert.ToDouble(cart.Amount) * Convert.ToDouble(product.Price)));
        }

        //Add selected objects to Session
        Session[User.Identity.GetUserId()] = carts;
    }

}