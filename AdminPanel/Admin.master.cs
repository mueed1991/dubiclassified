﻿using System;

public partial class AdminPanel_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminLogin"] == null)
        {
            Response.Redirect("~/AdminPanel/AdminLogin.aspx");
        }
    }

    public void AdminLogout(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("~/AdminPanel/AdminLogin.aspx");
    }
}