﻿using FamilySearch.Api.Ft;
using Gx.Conclusion;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gedcomx.Rs.Api.Test
{
    [TestFixture]
    public class ChangeHistoryTests
    {
        private FamilySearchFamilyTree tree;

        [TestFixtureSetUp]
        public void Initialize()
        {
            tree = new FamilySearchFamilyTree(true);
            tree.AuthenticateViaOAuth2Password("sdktester", "1234sdkpass", "WCQY-7J1Q-GKVV-7DNM-SQ5M-9Q5H-JX3H-CMJK");
        }

        [Test]
        public void TestReadCoupleRelationshipChangeHistory()
        {
            var husband = (FamilyTreePersonState)tree.AddPerson(TestBacking.GetCreateMalePerson()).Get();
            var wife = tree.AddPerson(TestBacking.GetCreateFemalePerson());
            var relationship = (FamilyTreeRelationshipState)husband.AddSpouse(wife).Get();
            relationship.AddFact(TestBacking.GetMarriageFact());
            var state = relationship.ReadChangeHistory();

            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.AreEqual(HttpStatusCode.OK, state.Response.StatusCode);
            Assert.IsNotNull(state.Page);
            Assert.IsNotNull(state.Page.Entries);
            Assert.Greater(state.Page.Entries.Count, 0);
        }
    }
}