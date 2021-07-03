using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Women_tshirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(1,"K");

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
                if (manproduct.Image == "woman_tshirt_simple.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Woman_Tshirt_Simple.aspx";
                }
                else
                {
                    if (manproduct.Image == "woman_tunika.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Woman_Tunika.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price + " PLN";
                lblName.CssClass = "productName";
                pnlwomantshirt.Controls.Add(imageButton);
                pnlwomantshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlwomantshirt.Controls.Add(lblName);
                pnlwomantshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlwomantshirt.Controls.Add(lblPrice);
                pnlwomantshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlwomantshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}