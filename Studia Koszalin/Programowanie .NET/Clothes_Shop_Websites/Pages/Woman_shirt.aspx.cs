using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Woman_shirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(3, "K");

        if (manproducts != null)
        {
            foreach (Product manproduct in manproducts)
            {
                Panel Typepanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = "~/Images/" + manproduct.Image;
                imageButton.CssClass = "productImage";
                if (manproduct.Image == "woman_shirt_simple.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Woman_Shirt_Simple.aspx";
                }
                else
                {
                    if (manproduct.Image == "woman_shirt_cross.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Woman_Shirt_Cross.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                pnlwomanshirt.Controls.Add(imageButton);
                pnlwomanshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanshirt.Controls.Add(lblName);
                pnlwomanshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanshirt.Controls.Add(lblPrice);
                pnlwomanshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlwomanshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}