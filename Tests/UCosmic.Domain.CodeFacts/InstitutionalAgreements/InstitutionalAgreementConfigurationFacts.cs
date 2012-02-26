﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using UCosmic.Domain.Establishments;

namespace UCosmic.Domain.InstitutionalAgreements
{
    // ReSharper disable UnusedMember.Global
    public class InstitutionalAgreementConfigurationFacts
    // ReSharper restore UnusedMember.Global
    {
        [TestClass]
        public class ForEstablishmentIdProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const int value = 8;
                var entity = new InstitutionalAgreementConfiguration { ForEstablishmentId = value };
                entity.ShouldNotBeNull();
                entity.ForEstablishmentId.ShouldEqual(value);
            }
        }

        [TestClass]
        public class ForEstablishmentProperty
        {
            [TestMethod]
            public void IsVirtual()
            {
                new InstitutionalAgreementConfigurationRuntimeEntity();
            }
            private class InstitutionalAgreementConfigurationRuntimeEntity : InstitutionalAgreementConfiguration
            {
                public override Establishment ForEstablishment
                {
                    get { return null; }
                    set { }
                }
            }
        }

        [TestClass]
        public class IsCustomTypeAllowedProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const bool value = true;
                var entity = new InstitutionalAgreementConfiguration { IsCustomTypeAllowed = value };
                entity.ShouldNotBeNull();
                entity.IsCustomTypeAllowed.ShouldEqual(value);
            }
        }

        [TestClass]
        public class IsCustomStatusAllowedProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const bool value = true;
                var entity = new InstitutionalAgreementConfiguration { IsCustomStatusAllowed = value };
                entity.ShouldNotBeNull();
                entity.IsCustomStatusAllowed.ShouldEqual(value);
            }
        }

        [TestClass]
        public class IsCustomContactTypeAllowedProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const bool value = true;
                var entity = new InstitutionalAgreementConfiguration { IsCustomContactTypeAllowed = value };
                entity.ShouldNotBeNull();
                entity.IsCustomContactTypeAllowed.ShouldEqual(value);
            }
        }

        [TestClass]
        public class AllowedTypeValuesProperty
        {
            [TestMethod]
            public void IsVirtual()
            {
                new InstitutionalAgreementConfigurationRuntimeEntity();
            }
            private class InstitutionalAgreementConfigurationRuntimeEntity : InstitutionalAgreementConfiguration
            {
                public override ICollection<InstitutionalAgreementTypeValue> AllowedTypeValues
                {
                    get { return null; }
                    set { }
                }
            }
        }

        [TestClass]
        public class AllowedStatusValuesProperty
        {
            [TestMethod]
            public void IsVirtual()
            {
                new InstitutionalAgreementConfigurationRuntimeEntity();
            }
            private class InstitutionalAgreementConfigurationRuntimeEntity : InstitutionalAgreementConfiguration
            {
                public override ICollection<InstitutionalAgreementStatusValue> AllowedStatusValues
                {
                    get { return null; }
                    set { }
                }
            }
        }

        [TestClass]
        public class AllowedContactTypeValuesProperty
        {
            [TestMethod]
            public void IsVirtual()
            {
                new InstitutionalAgreementConfigurationRuntimeEntity();
            }
            private class InstitutionalAgreementConfigurationRuntimeEntity : InstitutionalAgreementConfiguration
            {
                public override ICollection<InstitutionalAgreementContactTypeValue> AllowedContactTypeValues
                {
                    get { return null; }
                    set { }
                }
            }
        }
    }
}
