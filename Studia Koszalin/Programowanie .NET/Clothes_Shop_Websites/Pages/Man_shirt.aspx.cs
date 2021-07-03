using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_shirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(3, "M");

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
                if (manproduct.Image == "man_shirt_simple.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_shirt_simple.aspx";
                }
                else
                {
                    if (manproduct.Image == "man_shirt_cross.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Shirt_Cross.aspx";
                    }
                    else
                    {

                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                pnlmanshirt.Controls.Add(imageButton);
                pnlmanshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlmanshirt.Controls.Add(lblName);
                pnlmanshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlmanshirt.Controls.Add(lblPrice);
                pnlmanshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlmanshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}