using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_tshirt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    public void FillPage()
    {
        ManProductModel manproductModel = new ManProductModel();
        List<Product> manproducts = manproductModel.GetProductsByType(1,"M");
        
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
                if (manproduct.Image == "man_simple_tshirt.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_Tshirt_Simple.aspx";
                }
                else
                {
                    if (manproduct.Image == "man_tshirt_picture.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Tshirt_Picture.aspx";
                    }
                    else
                    {
                        
                    }
                }

                lblName.Text = manproduct.Name;
                lblName.CssClass = "productName";
                lblPrice.Text = manproduct.Price+" PLN";
                pnlmantshirt.Controls.Add(imageButton);
                pnlmantshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlmantshirt.Controls.Add(lblName);
                pnlmantshirt.Controls.Add(new Literal { Text = "<br />" });
                pnlmantshirt.Controls.Add(lblPrice);
                pnlmantshirt.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlmantshirt.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}