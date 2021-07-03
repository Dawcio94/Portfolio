using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_Jacket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(4, "M");

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
                if (manproduct.Image == "man_jacket_sport.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_Jacket_Sport.aspx";
                }
                else
                {
                    if (manproduct.Image == "man_coat.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Coat.aspx";
                    }
                    else
                    {
                      
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlmanjacket.Controls.Add(imageButton);
                pnlmanjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlmanjacket.Controls.Add(lblName);
                pnlmanjacket.Controls.Add(new Literal { Text = "<br />" });
                pnlmanjacket.Controls.Add(lblPrice);
                pnlmanjacket.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlmanjacket.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}