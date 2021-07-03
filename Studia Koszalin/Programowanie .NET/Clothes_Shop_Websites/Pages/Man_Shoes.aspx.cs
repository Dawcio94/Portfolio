using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_Shoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(5, "M");

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
                if (manproduct.Image == "man_shoes_sport.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_Shoes_Sport.aspx";
                }
                else
                {
                    if (manproduct.Image == "man_shoes_elegant.jpeg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Shoes_Elegant.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                pnlmanshoes.Controls.Add(imageButton);
                pnlmanshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlmanshoes.Controls.Add(lblName);
                pnlmanshoes.Controls.Add(new Literal { Text = "<br />" });
                pnlmanshoes.Controls.Add(lblPrice);
                pnlmanshoes.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlmanshoes.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}