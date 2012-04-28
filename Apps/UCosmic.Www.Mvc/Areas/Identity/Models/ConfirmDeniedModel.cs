﻿namespace UCosmic.Www.Mvc.Areas.Identity.Models
{
    public class ConfirmDeniedModel
    {
        public ConfirmDeniedModel(ConfirmDeniedBecause reason, string intent)
        {
            Reason = reason;
            Intent = intent;
        }

        public ConfirmDeniedBecause Reason { get; private set; }
        public string Intent { get; private set; }
    }
}