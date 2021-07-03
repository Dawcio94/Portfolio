using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Women_Clothes : System.Web.UI.Page
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

                imageButton.ImageUrl = "~/Images/" + producttype.Image2;
                imageButton.CssClass = "productImage";
                if (producttype.Image2 == "woman_tshirt.jpg")
                {
                    imageButton.PostBackUrl = "~/Pages/Women_tshirt.aspx";
                }
                else
                {
                    if (producttype.Image2 == "woman_underwear.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Women_Underwear.aspx";
                    }
                    else
                    {
                        if (producttype.Image2 == "woman_shirt.jpg")
                        {
                            imageButton.PostBackUrl = "~/Pages/Woman_shirt.aspx";
                        }
                        else
                        {
                            if (producttype.Image2 == "woman_jacket.jpg")
                            {
                                imageButton.PostBackUrl = "~/Pages/Woman_Jacket.aspx";
                            }
                            else
                            {
                                imageButton.PostBackUrl = "~/Pages/Woman_shoes.aspx";
                            }
                        }
                    }
                }

                lblName.Text = producttype.Name;
                lblName.CssClass = "productName";
                pnlProducttypewomen.Controls.Add(imageButton);
                pnlProducttypewomen.Controls.Add(new Literal { Text = "<br />" });
                pnlProducttypewomen.Controls.Add(lblName);
                pnlProducttypewomen.Controls.Add(new Literal { Text = "<br />" });
                pnlProducttypewomen.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlProducttypewomen.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}