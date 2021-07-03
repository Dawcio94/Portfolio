using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Woman_Jacket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(4, "K");

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
                if (manproduct.Image == "woman_jacket_sport.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Woman_Jacket_Sport.aspx";
                }
                else
                {
                    if (manproduct.Image == "woman_coat.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Woman_Coat.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlwomanjacket.Controls.Add(imageButton);
                pnlwomanjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanjacket.Controls.Add(lblName);
                pnlwomanjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanjacket.Controls.Add(lblPrice);
                pnlwomanjacket.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlwomanjacket.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}