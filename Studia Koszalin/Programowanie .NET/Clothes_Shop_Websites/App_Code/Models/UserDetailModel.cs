/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetailModel
/// </summary>
   / public class UserDetailModel
    {
        public UserDetail GetUserInformation(string guId)
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
            var info = (from x in db.UserDetails
                        where x.Guid == guId
                        select x).FirstOrDefault();
            return info;
        }

        public void InsertUserDetail(UserDetail userDetail)
        {
            Clothes_ShopEntities2 db = new Clothes_ShopEntities2();
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
        }
    }*/