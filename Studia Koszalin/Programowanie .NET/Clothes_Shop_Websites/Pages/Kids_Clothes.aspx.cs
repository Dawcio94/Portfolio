using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Kids_Clothes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    public void FillPage()
    {
        ProductTypeModel producttypeModel = new ProductTypeModel();
        List<ProductType> productstype = producttypeModel.GetAllProductsType();
        if (productstype != null)
        {
            foreach (ProductType producttype in productstype)
            {
                Panel Typepanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = "~/Images/" + producttype.Image3;
                imageButton.CssClass = "productImage";
                if (producttype.Image3 == "kids_tshirt.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Kids_tshirt.aspx";
                }
                else
                {
                    if (producttype.Image3 == "kids_underwear.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Kids_Underwear.aspx";
                    }
                    else
                    {
                        if (producttype.Image3 == "kids_shirt.jpg")
                        {
                            imageButton.PostBackUrl = "~/Pages/Kids_shirt.aspx";
                        }
                        else
                        {
                            if (producttype.Image3 == "kids_jacket.jpg")
                            {
                                imageButton.PostBackUrl = "~/Pages/Kids_Jacket.aspx";
                            }
                            else
                            {
                                imageButton.PostBackUrl = "~/Pages/Kids_shoes.aspx";
                            }
                        }
                    }
                }

                lblName.Text = producttype.Name;
                lblName.CssClass = "productName";
                pnlproducttypekids.Controls.Add(imageButton);
                pnlproducttypekids.Controls.Add(new Literal { Text = "<br />" });
                pnlproducttypekids.Controls.Add(lblName);
                pnlproducttypekids.Controls.Add(new Literal { Text = "<br />" });
                pnlproducttypekids.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlproducttypekids.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}