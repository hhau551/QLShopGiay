﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopGiay.Constant
{
    public class SessionKey
    {
        public static class User
        {
            public const string UserName = "UserName";
            public const string FullName = "FullName";
            public const string Valid = "Valid";
            public const string Avatar = "Avatar";
            public const int User_ID = 0;
            public const string RoleID = "RoleID";
            public const string UserContext = "UserContext";
        }

        public static class Guest
        {
            public const string Guest_UserName = "Guest_UserName";
            public const string Guest_FullName = "Guest_FullName";
            public const string Valid = "Valid";
            public const string Guest_Avatar = "Guest_Avatar";
            public const int Guest_ID = 0;
            public const string GuestContext = "GuestContext";
        }
        public const string CARTKEY = "cart";
    }
}
