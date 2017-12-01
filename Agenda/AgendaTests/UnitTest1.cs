using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace AgendaTests
{
    [TestClass]
    public class UnitTest1
    {
        Agenda.Agenda agenda;

        [TestInitialize]
        public void Initialize()
        {
            agenda = new Agenda.Agenda {
                ContactList=new List<Agenda.Contact>()
                {
                    new Agenda.Contact
                    {
                        FirstName="firstname"
                    },
                    new Agenda.Contact
                    {
                        LastName="lastname"
                    },
                    new Agenda.Contact
                    {
                        Nickname="nickname"
                    }
                }
            };
        }

        [TestMethod]
        public void ShouldFindBasedOnFirstName()
        {
            var result = agenda.Search("first");
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("firstname", result.First().FirstName);
        }

        [TestMethod]
        public void ShouldFindBasedOnLastName()
        {
            var result = agenda.Search("last");
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("lastname", result.First().LastName);
        }

        [TestMethod]
        public void ShouldFindBasedOnNickname()
        {
            var result = agenda.Search("nick");
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("nickname", result.First().Nickname);
        }        
    }
}
