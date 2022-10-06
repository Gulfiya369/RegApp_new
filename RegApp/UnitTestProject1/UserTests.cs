using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegApp;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestMethodUser1()
        {
            User password = new User();
            string actual = User.TestPassword("Password#");
            string expected = "Пароль нормальный";
            Assert.AreNotEqual(actual, expected);
            
        }


        [TestMethod]
        public void TestMethodUser2()
        {
            User password = new User();
            string actual = User.TestPassword("##PasswordPassword#");
            string expected = "Неверная длина пароля";
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethodUser3()
        {
            User password = new User();
            string actual = User.TestPassword("Password12");
            string expected = "Пароль должен содержать специальные символы !@#$%^&*";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethodUser4()
        {
            User password = new User();
            string actual = User.TestPassword("#Password#");
            string expected = "Пароль должен содержать цифры";
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethodUser5()
        {
            User password = new User();
            string actual = User.TestPassword("#PASSWORD#");
            string expected = "Пароль должен содержать буквы нижнего регистра";
            Assert.AreNotEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethodUser6()
        {
            User password = new User();
            string actual = User.TestPassword("#password#");
            string expected = "Пароль должен содержать буквы верхнего регистра";
            Assert.AreNotEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethodUser7()
        {
            User password = new User();
            string actual = User.TestPassword("!@#$%^&*");
            string expected = "Пароль нормальный";
            Assert.AreNotEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethodUser8()
        {
            User password = new User();
            string actual = User.TestPassword("#Password# ");
            string expected = "Пароль нормальный";
            Assert.AreNotEqual(actual, expected);
        }

       
        }
    }

