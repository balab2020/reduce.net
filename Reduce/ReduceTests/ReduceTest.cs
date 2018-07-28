namespace ReduceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Reduce;
    using System.Linq;

    [TestClass]
    public class ReduceTest
    {
        class Employee {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        [TestMethod]
        public void Reduce_CalledWithNumbers_SumValueReturned()
        {
            //arrange
            var numbers = new List<int> { 1, 2, 3, 4 };
            //act
            var sum = numbers.Reduce( (acc,cur) => { return acc + cur; },0);
            //assert
            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void Reduce_CalledWithNumbers_MaxValueReturned()
        {
            //arrange
            var numbers = new List<int> { 1, 2, 3, 4 };
            //act
            var sum = numbers.Reduce((acc, cur) => { return acc < cur ? cur : acc; }, 0);
            //assert
            Assert.AreEqual(4, sum);
        }

        [TestMethod]
        public void Reduce_CalledWithEmployees_SeniorEmployeeReturned()
        {
            //arrange
            var employees = new List<Employee> {
                new Employee {Age=60, Name="Bala" },
                new Employee {Age=23, Name="Murugan" }
            };
            //act
            var senior = employees.Reduce((acc, cur) => { return acc.Age < cur.Age ? cur : acc; }, employees.First());
            //assert
            Assert.AreEqual("Bala", senior.Name);
        }
    }
}
