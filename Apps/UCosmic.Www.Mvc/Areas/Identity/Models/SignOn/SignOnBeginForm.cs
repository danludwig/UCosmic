﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using UCosmic.Www.Mvc.Models;

namespace UCosmic.Www.Mvc.Areas.Identity.Models.SignOn
{
    public class SignOnBeginForm : IReturnUrl
    {
        public const string EmailAddressPropertyName = "EmailAddress";
        public const string EmailAddressDisplayName = "Email Address";
        public const string EmailAddressWatermark = "Enter your work email address";

        [UIHint("SignOnEmailAddress")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = EmailAddressDisplayName, Prompt = EmailAddressWatermark)]
        [Remote("ValidateEmailAddress", "SignOn", "Identity", HttpMethod = "POST")]
        public string EmailAddress { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
