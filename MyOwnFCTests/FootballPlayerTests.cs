using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOwnFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnFC.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        
           FootballPlayer playerTitleOneWord = new FootballPlayer(1, "R", 17 , 29 );
           FootballPlayer player = new FootballPlayer(2, "David", 1, 10);
           FootballPlayer player2 = new FootballPlayer(3, "Lucy", 16, 100);

        

        [TestMethod()]

        
        public void ValidateNameTest()
        {
            // Arrange

            //Act

      

            //Assert

            Assert.ThrowsException<ArgumentException>(() => playerTitleOneWord.ValidateName());
        }
        [TestMethod()]
        public void ValidateAge()
        {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateAge());
        }
        [TestMethod()]
        public void ValidateShirtNumber()
        {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player2.ValidateShirtNumber());
        }
    }
}