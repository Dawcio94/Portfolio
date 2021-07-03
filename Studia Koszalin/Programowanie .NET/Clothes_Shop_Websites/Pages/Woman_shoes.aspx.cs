using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Woman_shoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(5, "K");

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
                if (manproduct.Image == "woman_sport_shoes.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Woman_Sport_Shoes.aspx";
                }
                else
                {
                    if (manproduct.Image == "woman_highheels.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Woman_HighHeels.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlwomanshoes.Controls.Add(imageButton);
                pnlwomanshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanshoes.Controls.Add(lblName);
                pnlwomanshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanshoes.Controls.Add(lblPrice);
                pnlwomanshoes.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlwomanshoes.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}