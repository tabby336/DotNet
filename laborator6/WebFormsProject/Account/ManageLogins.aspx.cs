﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace WebFormsProject.Account
{
    public partial class ManageLogins : Page
    {
        protected string SuccessMessage { get; private set; }

        protected bool CanRemoveExternalLogins { get; private set; }

        private bool HasPassword(ApplicationUserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            CanRemoveExternalLogins = manager.GetLogins(User.Identity.GetUserId()).Count() > 1;

            SuccessMessage = string.Empty;
            successMessage.Visible = !string.IsNullOrEmpty(SuccessMessage);
        }

        public IEnumerable<UserLoginInfo> GetLogins()
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var accounts = manager.GetLogins(User.Identity.GetUserId());
            CanRemoveExternalLogins = accounts.Count() > 1 || HasPassword(manager);
            return accounts;
        }

        public void RemoveLogin(string loginProvider, string providerKey)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var result = manager.RemoveLogin(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            var msg = string.Empty;
            if (result.Succeeded)
            {
                var user = manager.FindById(User.Identity.GetUserId());
                signInManager.SignIn(user, false, false);
                msg = "?m=RemoveLoginSuccess";
            }
            Response.Redirect("~/Account/ManageLogins" + msg);
        }
    }
}