using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_Underwear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(2, "D");

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
                if (manproduct.Image == "kids_underwear.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Girl_Underwear.aspx";
                }
                else
                {
                    if (manproduct.Image == "boy_slips.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Boy_Underwear.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlkidsunderwear.Controls.Add(imageButton);
                pnlkidsunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsunderwear.Controls.Add(lblName);
                pnlkidsunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsunderwear.Controls.Add(lblPrice);
                pnlkidsunderwear.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlkidsunderwear.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}