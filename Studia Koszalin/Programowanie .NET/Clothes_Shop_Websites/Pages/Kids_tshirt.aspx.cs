using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_tshirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(1,"D");

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
                if (manproduct.Image == "boy_tshirt.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Boy_Tshirt.aspx";
                }
                else
                {
                    if (manproduct.Image == "girl_tshirt.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Girl_Tshirt.aspx";
                    }
                    else
                    {
                    }
                }

                lblName.Text = manproduct.Name;
                lblPrice.Text = manproduct.Price.ToString() + " PLN";
                lblName.CssClass = "productName";
                pnlkidstshirt.Controls.Add(imageButton);
                pnlkidstshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlkidstshirt.Controls.Add(lblName);
                pnlkidstshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlkidstshirt.Controls.Add(lblPrice);
                pnlkidstshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlkidstshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }


}