﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace UCosmic.Domain.InstitutionalAgreements
{
    public static class InstitutionalAgreementFileFacts
    {
        [TestClass]
        public class AgreementProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                var value = new InstitutionalAgreement();
                var entity = new InstitutionalAgreementFile { Agreement = value };
                entity.ShouldNotBeNull();
                entity.Agreement.ShouldEqual(value);
            }

            [TestMethod]
            public void IsVirtual()
            {
                new InstitutionalAgreementFileRuntimeEntity();
            }
            private class InstitutionalAgreementFileRuntimeEntity : InstitutionalAgreementFile
            {
                public override InstitutionalAgreement Agreement
                {
                    get { return null; }
                    set { }
                }
            }
        }
    }
}
