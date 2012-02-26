﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace UCosmic.Domain.Places
{
    // ReSharper disable UnusedMember.Global
    public class GeoPlanetPlaceBelongToFacts
    // ReSharper restore UnusedMember.Global
    {
        [TestClass]
        public class PlaceWoeIdProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const int value = 3;
                var entity = new GeoPlanetPlaceBelongTo { PlaceWoeId = value };
                entity.ShouldNotBeNull();
                entity.PlaceWoeId.ShouldEqual(value);
            }
        }

        [TestClass]
        public class GeoPlanetPlaceProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                var value = new GeoPlanetPlace();
                var entity = new GeoPlanetPlaceBelongTo { GeoPlanetPlace = value };
                entity.ShouldNotBeNull();
                entity.GeoPlanetPlace.ShouldEqual(value);
            }

            [TestMethod]
            public void IsVirtual()
            {
                new GeoPlanetPlaceBelongToRuntimeEntity();
            }
            private class GeoPlanetPlaceBelongToRuntimeEntity : GeoPlanetPlaceBelongTo
            {
                public override GeoPlanetPlace GeoPlanetPlace
                {
                    get { return null; }
                    set { }
                }
            }
        }

        [TestClass]
        public class BelongToWoeIdProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                const int value = 3;
                var entity = new GeoPlanetPlaceBelongTo { BelongToWoeId = value };
                entity.ShouldNotBeNull();
                entity.BelongToWoeId.ShouldEqual(value);
            }
        }

        [TestClass]
        public class BelongsToProperty
        {
            [TestMethod]
            public void HasGetSet()
            {
                var value = new GeoPlanetPlace();
                var entity = new GeoPlanetPlaceBelongTo { BelongsTo = value };
                entity.ShouldNotBeNull();
                entity.BelongsTo.ShouldEqual(value);
            }

            [TestMethod]
            public void IsVirtual()
            {
                new GeoPlanetPlaceBelongToRuntimeEntity();
            }
            private class GeoPlanetPlaceBelongToRuntimeEntity : GeoPlanetPlaceBelongTo
            {
                public override GeoPlanetPlace BelongsTo
                {
                    get { return null; }
                    set { }
                }
            }
        }
    }
}
