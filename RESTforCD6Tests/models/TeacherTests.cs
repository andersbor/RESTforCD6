using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTforCD6.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTforCD6.models.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void ValidateSalaryTest()
        {
            Teacher teacherZeroSalary = new() { Name = "Anders", Salary = 0 };
            Teacher teacherNegativeSalary = new() { Name = "Bente", Salary = -1 };
            Teacher teacherPositiveSalary = new() { Name = "Carl", Salary = 1 };

            teacherPositiveSalary.ValidateSalary();
            teacherZeroSalary.ValidateSalary();
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => teacherNegativeSalary.ValidateSalary());
        }
    }
}