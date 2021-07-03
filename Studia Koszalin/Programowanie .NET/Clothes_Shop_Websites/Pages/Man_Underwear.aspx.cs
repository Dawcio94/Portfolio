using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_Underwear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(2, "M");

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
                if (manproduct.Image == "man_boxers.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_Boxers.aspx";
                }
                else
                {
                    if (manproduct.Image == "man_slips.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Slips.aspx";
                    }
                    else
                    {
                        if (manproduct.Image == "man_socks.jpg")
                        {
                            imageButton.PostBackUrl = "~/Pages/Man_Socks.aspx";
                        }
                        else
                        {

                        }
                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                pnlmanunderwear.Controls.Add(imageButton);
                pnlmanunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlmanunderwear.Controls.Add(lblName);
                pnlmanunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlmanunderwear.Controls.Add(lblPrice);
                pnlmanunderwear.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlmanunderwear.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}