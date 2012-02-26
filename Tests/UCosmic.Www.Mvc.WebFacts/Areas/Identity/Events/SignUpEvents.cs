﻿using System;
using System.Linq;
using System.Web.Security;
using TechTalk.SpecFlow;
using UCosmic.Orm;
using UCosmic.Www.Mvc.SpecFlow;

namespace UCosmic.Www.Mvc.Areas.Identity.Events
{
    [Binding]
    // ReSharper disable UnusedMember.Global
    public class SignUpEvents : TestRunEvents
    {
        [BeforeScenario("SignUpResetNewUsers")]
        [AfterScenario("SignUpResetNewUsers")]
        public static void ResetSignUpData()
        {
            var membersToClear = new[] { "new@bjtu.edu.cn", "new@usil.edu.pe", "new@griffith.edu.au" };
            using (var context = new UCosmicContext())
            {
                foreach (var memberToClear in membersToClear)
                {
                    var member = Membership.GetUser(memberToClear);
                    if (member != null)
                        Membership.DeleteUser(memberToClear);

                    var person = context.People.SingleOrDefault(p => p.User != null 
                        && memberToClear.Equals(p.User.UserName, StringComparison.OrdinalIgnoreCase))
                        ?? context.People.SingleOrDefault(p => p.Emails.Any(
                            e => memberToClear.Equals(e.Value, StringComparison.OrdinalIgnoreCase)));
                    if (person == null) continue;
                    if (person.User != null)
                        context.Users.Remove(person.User);
                    context.People.Remove(person);
                }
                context.SaveChanges();
            }

        }

    }
    // ReSharper restore UnusedMember.Global
}
