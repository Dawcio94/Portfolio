using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_Jacket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(4, "D");

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
                if (manproduct.Image == "boy_jacket.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Boy_Jacket.aspx";
                }
                else
                {
                    if (manproduct.Image == "girl_jacket.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Girl_Jacket.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price.ToString()+"PLN";
                pnlkidsjacket.Controls.Add(imageButton);
                pnlkidsjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsjacket.Controls.Add(lblName);
                pnlkidsjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsjacket.Controls.Add(lblPrice);
                pnlkidsjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlkidsjacket.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlkidsjacket.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}