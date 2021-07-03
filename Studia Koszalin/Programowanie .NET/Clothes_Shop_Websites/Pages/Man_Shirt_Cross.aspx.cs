using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_Shirt_Cross : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string clientId = Context.User.Identity.GetUserName();
        if (clientId != null)
        {
            int amount = Convert.ToInt32(ddlAmount.SelectedValue);

            Cart cart = new Cart
            {
                Amount = amount,
                ClientID = clientId,
                DatePurchased = DateTime.Now,
                IsInCart = true,
                ProductID = 1
            };

            CartModel model = new CartModel();
            lblResult.Text = model.InsertCart(cart);
        }
        else
        {
            lblResult.Text = "Proszę się zalogować w celu zakupu.";
        }
    }

    public void FillPage()
    {
        ManProductModel productmodel = new ManProductModel();
        Product product = productmodel.GetProduct(1);

        lblTitle.Text = product.Name;
        lblDescription.Text = product.Description;
        lblPrice.Text = "Cena za sztukę:<br/>PLN " + product.Price;
        imgProduct.ImageUrl = "~/Images/" + product.Image;
        lblItemNr.Text = product.ProductID.ToString();

        //Fill amount list with numbers 1-20
        int[] amount = Enumerable.Range(1, 20).ToArray();
        ddlAmount.DataSource = amount;
        ddlAmount.AppendDataBoundItems = true;
        ddlAmount.DataBind();

    }
}