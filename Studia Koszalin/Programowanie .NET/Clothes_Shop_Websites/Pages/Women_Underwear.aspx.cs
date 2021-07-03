using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Women_Underwear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(2, "K");

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
                if (manproduct.Image == "woman_bra_simple.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Woman_Bra_Simple.aspx";
                }
                else
                {
                    if (manproduct.Image == "woman_bra_push.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Woman_Bra_Push.aspx";
                    }
                    else
                    {
                        if (manproduct.Image == "woman_figs.jpg")
                        {
                            imageButton.PostBackUrl = "~/Pages/Woman_Figs.aspx";
                        }
                        else
                        {
                            imageButton.PostBackUrl = "~/Pages/Woman_Strings.aspx";
                        }
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString()+" PLN";
                lblName.CssClass = "productName";
                pnlwomanunderwear.Controls.Add(imageButton);
                pnlwomanunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanunderwear.Controls.Add(lblName);
                pnlwomanunderwear.Controls.Add(new Literal { Text = "<br />" });
                pnlwomanunderwear.Controls.Add(lblPrice);
                pnlwomanunderwear.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlwomanunderwear.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }

}