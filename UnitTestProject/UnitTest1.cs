using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryTest;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Check_Сorrect_FirstName()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_FirstName_Big()
        {
            bool result = false;

            var actual = TestClass.Validate("123456789012345678901234567890123456789012345678900",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_FirstName_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        public void Check_Сorrect_LastName()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_LastName_Big()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных", "123456789012345678901234567890123456789012345678900",
                  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_LastName_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli",
                 "121212");

            Assert.AreEqual(result, actual);
        }

        
        
        public void Check_Сorrect_Passport()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Passport()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных", "Кирилл", 
                  "1415876578111111111111111111111111111111111111111",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_Passport_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        public void Check_Сorrect_Phone_11Symbols()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Сorrect_Phone_12Symbols()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "+79111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_Phone()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "8(911)11-111-11", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        public void Check_Inorrect_Phone_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Сorrect_Mail()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Mail_Big_Symbol()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_Mail_Big_NotSymbol()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyhgmail.com11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Mail_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Mail_Small_Not_Symbol()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл", "1415876578",
                "89111111111", "1111111", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }

        public void Check_Сorrect_Login()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Login_Big()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных", "Кирилл", "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                "121212");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_Login_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", ""
                , "121212");

            Assert.AreEqual(result, actual);
        }

        public void Check_Сorrect_Password()
        {
            bool result = true;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "121212");

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Check_Inorrect_Password_Big()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных", "Кирилл", 
                  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "12121211111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Check_Inorrect_Password_Null()
        {
            bool result = false;

            var actual = TestClass.Validate("Чудных",
                "Кирилл",  "1415876578",
                "89111111111", "kira.chudnyh@gmail.com", "Rishli"
                , "");

            Assert.AreEqual(result, actual);
        }
    }
}
