using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Man_Clothes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    public void FillPage()
    {       
        ProductTypeModel producttypeModel = new ProductTypeModel();
        List<ProductType> productstype = producttypeModel.GetAllProductsType();
        
        if(productstype != null)
        {
            foreach (ProductType producttype in productstype)
            {
                Panel Typepanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();

                imageButton.ImageUrl = "~/Images/" + producttype.Image;
                imageButton.CssClass = "productImage";
                if (producttype.Image == "miniatura_t-shirtm.png")
                {
                    imageButton.PostBackUrl = "~/Pages/Man_tshirt.aspx";
                }
                else
                {
                    if (producttype.Image == "man_underwear.jpg")
                    {
                        imageButton.PostBackUrl = "~/Pages/Man_Underwear.aspx";
                    }
                    else
                    {
                        if (producttype.Image == "man_shirt.jpg")
                        {
                            imageButton.PostBackUrl = "~/Pages/Man_shirt.aspx";
                        }
                        else
                        {
                            if (producttype.Image == "man_jacket.jpg")
                            {
                                imageButton.PostBackUrl = "~/Pages/Man_Jacket.aspx";
                            }
                            else
                            {
                                imageButton.PostBackUrl = "~/Pages/Man_shoes.aspx";
                            }
                        }
                    }
                }
                
                lblName.Text = producttype.Name;
                lblName.CssClass = "productName";
                pnlProductsType.Controls.Add(imageButton);
                pnlProductsType.Controls.Add(new Literal { Text = "<br/>" });
                pnlProductsType.Controls.Add(lblName);
                pnlProductsType.Controls.Add(new Literal { Text = "<br/>" });
                pnlProductsType.Controls.Add(Typepanel);
            }
        }
        else
        {
            pnlProductsType.Controls.Add(new Literal { Text = "No productType found!" });
        }
    }
}