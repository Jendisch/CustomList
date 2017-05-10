using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {


        //Tests for int


        //[TestMethod]
        //public void Count_CountNumberOfObjectsInList_ReturnNumberOfItems()
        //{
        //    List<int> list = new List<int>();
        //    //Arrange
        //    int result;
        //    int expected = 0;

        //    //Act
        //    result = list.Count;

        //    //Assert
        //    Assert.AreEqual(result, expected);
        //}

        //[TestMethod]
        //public void Add_AddObjectToList_ReturnLengthOfListWithAddedElement()
        //{
        //    List<int> list = new List<int>();
        //    // Arrange
        //    int number = 3;
        //    int expected = 1;
        //    int result;

        //    // Act
        //    list.Add(number);
        //    result = list.Count;

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}

        //[TestMethod]
        //public void Add_AddFirstObjectToList_ReturnsSameObjectThatWasAdded()
        //{
        //    List<int> list = new List<int>();
        //    // Arrange
        //    int number = 3;

        //    // Act
        //    list.Add(number);

        //    // Assert
        //    Assert.AreEqual(number, list[0]);
        //}

        //[TestMethod]
        //public void Add_AddTwoObjectsToList_ReturnsFirstObjectThatWasAdded()
        //{
        //    List<int> list = new List<int>();
        //    // Arrange
        //    int number = 1;
        //    int biggernumber = 3;

        //    // Act
        //    list.Add(number);
        //    list.Add(biggernumber);

        //    // Assert
        //    Assert.AreEqual(number, list[0]);
        //}

        //[TestMethod]
        //public void Add_AddTwoObjectsToList_ReturnsSecondObjectThatWasAdded()
        //{
        //    List<int> list = new List<int>();
        //    // Arrange
        //    int number = 1;
        //    int biggernumber = 3;

        //    // Act
        //    list.Add(number);
        //    list.Add(biggernumber);

        //    // Assert
        //    Assert.AreEqual(biggernumber, list[1]);
        //}

        //[TestMethod]
        //public void Add_AddingMultipleObjectsToList_ReturnLengthOfListWithAddedElements()
        //{
        //    // Arrange
        //    List<int> list = new List<int>();
        //    int number = 1;
        //    int biggerNumber = 2;
        //    int biggestNumber = 3;
        //    int expected = 3;
        //    int result;

        //    // Act
        //    list.Add(number);
        //    list.Add(biggerNumber);
        //    list.Add(biggestNumber);
        //    result = list.Count;

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}

        //[TestMethod]
        //public void Add_AddStringToList_CheckAndSeeIfStringAndFirstPositionMatch()
        //{
        //    List<string> list = new List<string>();
        //    // Arrange
        //    string greeting = "Hello World!";

        //    // Act
        //    list.Add(greeting);

        //    // Assert
        //    Assert.AreEqual(greeting, list[0]);
        //}

        //[TestMethod]
        //public void Remove_RemoveAnObjectFromAList_ReturnBool()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3 };
        //    // Arrange
        //    int number = 2;
        //    bool result;

        //    // Act
        //    result = list.Remove(number);

        //    // Assert
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void Remove_RemoveAnObjectThatIsntThereFromAList_ReturnBool()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        //    // Arrange
        //    int number = 8;
        //    bool result;

        //    // Act
        //    result = list.Remove(number);

        //    // Assert
        //    Assert.IsFalse(result);
        //}

        //[TestMethod]
        //public void Remove_RemoveCertainObjectFromList_ReturnListWithRemovedObject()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        //    // Arrange
        //    int number = 5;

        //    // Act
        //    list.Remove(number);

        //    // Assert
        //    Assert.AreEqual(1, list[0]);
        //    Assert.AreEqual(2, list[1]);
        //    Assert.AreEqual(3, list[2]);
        //    Assert.AreEqual(4, list[3]);
        //}

        [TestMethod]
        public void Remove_RemoveCertainObjectMultipleFromList_ReturnListWithRemovedObject()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 1 };
            // Arrange
            int number = 1;

            // Act
            list.Remove(number);

            // Assert
            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(3, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(1, list[3]);
        }

        [TestMethod]
        public void Remove_RemoveCertainObjectMultipleFromList_ReturnListCountWithRemovedObject()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 1 };
            // Arrange
            int number = 1;
            int expected = 4;
            int result;

            // Act
            list.Remove(number);
            result = list.Capacity();

            // Assert
            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //public void Remove_RemoveObjectFromList_ReturnLengthOfListWithRemovedElement()
        //{
        //    List<int> list = new List<int>();
        //    //Arrange
        //    int number = 3;
        //    int expected = 0;
        //    int result;

        //    //Act
        //    list.Add(number);
        //    list.Remove(number);
        //    result = list.Capacity();

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}

        //[TestMethod]
        //public void Remove_RemoveMultipleObjectsFromList_ReturnLengthOfListWithRemovedElements()
        //{
        //    List<int> list = new List<int>();
        //    //Arrange
        //    int number = 1;
        //    int biggerNumber = 2;
        //    int biggestNumber = 3;
        //    int expected = 1;
        //    int result;

        //    //Act
        //    list.Add(number);
        //    list.Add(biggerNumber);
        //    list.Add(biggestNumber);
        //    list.Remove(biggerNumber);
        //    list.Remove(biggestNumber);
        //    result = list.Capacity();

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
    }
}


    
