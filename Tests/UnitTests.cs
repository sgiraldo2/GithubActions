﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubActionsLab
{
    [TestClass]
    public class Math
    {
        // Add
        [TestMethod]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        // Subtract
        [TestMethod]
        public void Subtract_Valid()
        {
            Assert.AreEqual(8, Program.Subtract("10", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(8, Program.Subtract("15", "7"));
        }

        [TestMethod]
        public void Subtract_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
        }

        [TestMethod]
        public void Subtract_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Multiply
        [TestMethod]
        public void Multiply_Valid()
        {
            Assert.AreEqual(20, Program.Multiply("10", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("5", "7"));
        }

        [TestMethod]
        public void Multiply_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
        }

        [TestMethod]
        public void Multiply_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Divide
        [TestMethod]
        public void Divide_Valid()
        {
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(1, Program.Divide("4", "4"));
            Assert.AreEqual(2.4, Program.Divide("12", "5"));
        }

        [TestMethod]
        public void Divide_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
        }

        [TestMethod]
        public void Divide_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
        }


        // Power
        [TestMethod]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(78125, Program.Power("5", "7"));
        }

        [TestMethod]
        public void Power_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
        }

        [TestMethod]
        public void Power_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
