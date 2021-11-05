using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;

namespace TestLab5
{
    [TestClass]
    public class TestTaskZ1 // тестирование задания №1
    {
        [TestMethod]
        public void Z1_TestMethod1_PositiveValue() // положительное значение
        {
            // исходные данные
            int n = 8;
            string expected = "ABCDEFGH"; // ожидаемое значение

            // получение значения с помощью тестируемого метода:
            Tasks g = new Tasks();
            string actual = g.Z1(n);

            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z1_TestMethod2_NegativeValue() // отрицательное значение
        {
            bool catched = false;
            try
            {
                int n = -2;

                Tasks g = new Tasks();
                g.Z1(n);
            }

            catch (ArgumentException e)
            {
                catched = true;
            }

            Assert.IsTrue(catched, "значение n не может быть отрицательным");
        }

        [TestMethod]
        public void Z1_TestMethod3_ExcessValue() // избыточное значение (n > 26)
        {
            int n = 32;

            Tasks g = new Tasks();
            Assert.ThrowsException<ArgumentException>(() => g.Z1(n), "значение n больше допустимого");
        }
    }

    [TestClass]
    public class TestTaskZ2 // тестирование задания №2
    {
        [TestMethod]
        public void Z2_TestMethod1_PositiveValue_LeapYear() // високосный год
        {
            int n = 1200;
            int expected = 366;

            Tasks g = new Tasks();
            int actual = g.Z2(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z2_TestMethod2_PositiveValue_RegularYear() // не високосный год
        {
            int n = 1900;
            int expected = 365;

            Tasks g = new Tasks();
            int actual = g.Z2(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z2_TestMethod3_NegativeValue_LeapYear() // високосный год (до н.э.)
        {
            int n = -1320;
            int expected = 366;

            Tasks g = new Tasks();
            int actual = g.Z2(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z2_TestMethod4_NegativeValue_RegularYear() // не високосный год (до н.э.)
        {
            int n = -1573;
            int expected = 365;

            Tasks g = new Tasks();
            int actual = g.Z2(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z2_TestMethod5_ZeroYear_RegularYear() // нулевой год (не високосный)
        {
            int n = 0;
            int expected = 365;

            Tasks g = new Tasks();
            int actual = g.Z2(n);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class TestTaskZ3 // тестирование задания №3
    {
        [TestMethod]
        public void Z3_TestMethod1_CorrectEmail() // корректный Email
        {
            string n = "pavel@mail.ru";
            bool expected = true;

            Tasks g = new Tasks();
            bool actual = g.Z3(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z3_TestMethod2_IncorrectEmail() // некорректный Email
        {
            string n = "fdggsdffd1561";

            Tasks g = new Tasks();
            Assert.ThrowsException<ArgumentException>(() => g.Z3(n), "некорректный Email");
        }
    }

    [TestClass]
    public class TestTaskZ4 // тестирование задания №4
    {
        [TestMethod]
        public void Z4_TestMethod1_CorrectString () // корректная строка
        {
            string n = "1234567890";
            int expected = 45;

            Tasks g = new Tasks();
            int actual = g.Z4(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z4_TestMethod2_IncorrectString() // некорректная строка
        {
            string n = "12.sdfg2224.sdf.12.311";

            Tasks g = new Tasks();
            Assert.ThrowsException<FormatException>(() => g.Z4(n), "некорректная строка");
        }
    }

    [TestClass]
    public class TestTaskZ5 // тестирование задания №5
    {
        [TestMethod]
        public void Z5_TestMethod1_CorrectValue() // корректное значение
        {
            double a = 25;
            double b = -3;
            double c = 7;
            double x1 = -5;
            double x2 = 5;
            double n = 8;

            double expected = 2199.69;

            Tasks g = new Tasks();
            double actual = g.Z5(a, b, c, x1, x2, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Z5_TestMethod2_IncorrectValue() // некорректное значение (n)
        {
            double a = 25;
            double b = -3;
            double c = 7;
            double x1 = -5;
            double x2 = 5;
            double n = -8;

            Tasks g = new Tasks();
            Assert.ThrowsException<ArgumentException>(() => g.Z5(a, b, c, x1, x2, n), "некорректное значение n");
        }
    }
}
