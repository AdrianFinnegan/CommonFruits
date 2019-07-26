using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace CommonFruits.Tests
{
    public class FruitFinderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindCommonFruit()
        {
            //Arrange
            var fruitFinder = new FruitFinder();
            var fruits = new List<string>{"Apple", "Pear", "Apple", "Orange", "Grape", "Orange", "Apple"};

            //Act
            var response = fruitFinder.GetFruit(fruits);

            //Assert
            response.Should().Be("Apple");
        }
    }
}