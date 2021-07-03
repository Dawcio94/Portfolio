using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_shirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(3,"D");

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
                if (manproduct.Image == "boy_shirt.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Boy_Shirt.aspx";
                }
                else
                {
                    if (manproduct.Image == "girl_shirt.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Girl_Shirt.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlkidsshirt.Controls.Add(imageButton);
                pnlkidsshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsshirt.Controls.Add(lblName);
                pnlkidsshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsshirt.Controls.Add(lblPrice);
                pnlkidsshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlkidsshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}