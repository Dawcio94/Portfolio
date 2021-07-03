using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_shoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(5, "D");

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
                if (manproduct.Image == "boy_shoes.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Boys_Shoes.aspx";
                }
                else
                {
                    if (manproduct.Image == "girl_shoes.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Girl_Shoes.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlkidsshoes.Controls.Add(imageButton);
                pnlkidsshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsshoes.Controls.Add(lblName);
                pnlkidsshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsshoes.Controls.Add(lblPrice);
                pnlkidsshoes.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlkidsshoes.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}