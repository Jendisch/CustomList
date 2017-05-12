using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class Test
    {


        //Add Tests


        [TestMethod]
        public void Count_CountNumberOfObjectsInList_ReturnNumberOfItems()
        {
            List<int> list = new List<int>();
            //Arrange
            int result;
            int expected = 0;

            //Act
            result = list.Count;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_AddObjectToList_ReturnLengthOfListWithAddedElement()
        {
            List<int> list = new List<int>();
            // Arrange
            int number = 3;
            int expected = 1;
            int result;

            // Act
            list.Add(number);
            result = list.Count;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_AddFirstObjectToList_ReturnsSameObjectThatWasAdded()
        {
            List<int> list = new List<int>();
            // Arrange
            int number = 3;

            // Act
            list.Add(number);

            // Assert
            Assert.AreEqual(number, list[0]);
        }

        [TestMethod]
        public void Add_AddTwoObjectsToList_ReturnsFirstObjectThatWasAdded()
        {
            List<int> list = new List<int>();
            // Arrange
            int number = 1;
            int biggernumber = 3;

            // Act
            list.Add(number);
            list.Add(biggernumber);

            // Assert
            Assert.AreEqual(number, list[0]);
        }

        [TestMethod]
        public void Add_AddTwoObjectsToList_ReturnsSecondObjectThatWasAdded()
        {
            List<int> list = new List<int>();
            // Arrange
            int number = 1;
            int biggernumber = 3;

            // Act
            list.Add(number);
            list.Add(biggernumber);

            // Assert
            Assert.AreEqual(biggernumber, list[1]);
        }

        [TestMethod]
        public void Add_AddingMultipleObjectsToList_ReturnLengthOfListWithAddedElements()
        {
            // Arrange
            List<int> list = new List<int>();
            int number = 1;
            int biggerNumber = 2;
            int biggestNumber = 3;
            int expected = 3;
            int result;

            // Act
            list.Add(number);
            list.Add(biggerNumber);
            list.Add(biggestNumber);
            result = list.Count;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_AddOneHundredTensToList_ReturnCountOfOneHundred()
        {
            List<int> list = new List<int>();
            // Arrange
            int amount = 100;
            int number = 10;

            // Act
            for (int i = 0; i < amount; i++)
            {
                list.Add(number);
            }

            // Assert
            Assert.AreEqual(amount, list.Count);
        }

        [TestMethod]
        public void Add_AddStringToList_CheckAndSeeIfStringAndFirstPositionMatch()
        {
            List<string> list = new List<string>();
            // Arrange
            string greeting = "Hello World!";

            // Act
            list.Add(greeting);

            // Assert
            Assert.AreEqual(greeting, list[0]);
        }


        //Remove Tests


        [TestMethod]
        public void Remove_RemoveAnObjectFromAList_ReturnBool()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            // Arrange
            int number = 2;
            bool result;

            // Act
            result = list.Remove(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Remove_RemoveAnObjectThatIsntThereFromAList_ReturnBool()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            // Arrange
            int number = 8;
            bool result;

            // Act
            result = list.Remove(number);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Remove_RemoveCertainObjectFromList_ReturnListWithRemovedObject()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            // Arrange
            int number = 5;

            // Act
            list.Remove(number);

            // Assert
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(4, list[3]);
        }

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
            result = list.CountList();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Remove_RemoveObjectFromList_ReturnLengthOfListWithRemovedElement()
        {
            List<int> list = new List<int>();
            //Arrange
            int number = 3;
            int expected = 0;
            int result;

            //Act
            list.Add(number);
            list.Remove(number);
            result = list.CountList();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Remove_RemoveMultipleObjectsFromList_ReturnLengthOfListWithRemovedElements()
        {
            List<int> list = new List<int>();
            //Arrange
            int number = 1;
            int biggerNumber = 2;
            int biggestNumber = 3;
            int expected = 1;
            int result;

            //Act
            list.Add(number);
            list.Add(biggerNumber);
            list.Add(biggestNumber);
            list.Remove(biggerNumber);
            list.Remove(biggestNumber);
            result = list.CountList();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Remove_RemoveStringFromList_ReturnBool()
        {
            List<string> list = new List<string>() { "Hello" };
            // Arrange
            string greeting = "Hello";
            bool result;

            // Act
            result = list.Remove(greeting);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Remove_RemoveCustomListFromList_ReturnBool()
        {
            List<List<int>> list = new List<List<int>>();
            // Arrange
            List<int> customList = new List<int>() { 1, 2, 3 };
            bool result;

            // Act
            list.Add(customList);
            result = list.Remove(customList);

            // Assert
            Assert.IsTrue(result);
        }


        //Override ToString Tests


        [TestMethod]
        public void ToString_OverrideOriginalToString_ReturnStringWithPeriodAndSpaceAdded()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //Arrange
            string expected = "1. 2. 3. 4. 5";
            string result;

            //Act
            result = list.ToString();

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_OverrideOriginalToStringUsingAString_ReturnStringWithPeriodAndSpaceAdded()
        {
            List<string> list = new List<string>() { "I", "Love", "Putting", "Periods", "Between", "Words", "For", "Emphasis" };
            //Arrange
            string expected = "I. Love. Putting. Periods. Between. Words. For. Emphasis";
            string result;

            //Act
            result = list.ToString();

            //Assert 
            Assert.AreEqual(expected, result);
        }


        //OverLoad Operator Tests


        [TestMethod]
        public void Operator_AddTwoListsTogether_ReturnListWithCombinedExpectedCount()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            List<int> list2 = new List<int>() { 5, 6, 7, 8 };
            // Arrange
            int expected = 8;
            List<int> add;
            int result;

            // Act
            add = list1 + list2;
            result = add.Count;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operator_AddTwoListsTogether_ReturnCombinedExpectedList()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            List<int> list2 = new List<int>() { 5, 6, 7, 8 };
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            // Arrange
            List<int> result;

            // Act
            result = list1 + list2;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Operator_AddTwoStringListsTogether_ReturnCombinedExpectedStringList()
        {
            List<string> family = new List<string>() { "Sam", "Brittany", "Lexi", "Katie" };
            List<string> friend = new List<string>() { "Holly", "Ally" };
            List<string> expected = new List<string>() { "Sam", "Brittany", "Lexi", "Katie", "Holly", "Ally" };
            // Arrange
            List<string> result;

            // Act
            result = family + friend;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Operator_SubtractOneListsItemsIfTheyArePresentInSecondList_ReturnExpectedCountOfNewList()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            List<int> list2 = new List<int>() { 2, 4 };
            //Arrange
            int expected = 2;
            List<int> add;
            int result;

            //Act
            add = list1 - list2;
            result = add.Count;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Operator_SubtractOneListsItemsIfTheyArePresentInSecondList_MakeSureEveryItemInNewListIsWhereItsSupposedToBe()
        {
            // Arrange
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int>() { 2, 4, 6 };
            List<int> expected = new List<int>() { 1, 3, 5 };
            List<int> result;

            // Act
            result = list1 - list2;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Operator_SubtractMultipleIdenticalItemsIfTheyArePresentInSecondList_ReturnExpectedNewList()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 3, 4, 5, 5, 5, 6 };
            List<int> list2 = new List<int>() { 2, 3, 5 };
            List<int> expected = new List<int>() { 1, 4, 6 };
            // Arrange
            List<int> result;

            // Act
            result = list1 - list2;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }



        //Zip Tests



        [TestMethod]
        public void Zip_ZipTogetherTwoIntLists_ReturnExpectedCount()
        {
            List<int> odd = new List<int>() { 1, 3, 5 };
            List<int> even = new List<int>() { 2, 4, 6 };
            // Arrange
            List<int> zipList;
            int expected = 6;
            int result;

            // Act
            zipList = odd.Zip(even);
            result = zipList.Count;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zip_ZipTogetherTwoIntLists_ReturnExpectedList()
        {
            List<int> odd = new List<int>() { 1, 3, 5 };
            List<int> even = new List<int>() { 2, 4, 6 };
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // Arrange
            List<int> result;

            // Act
            result = odd.Zip(even);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Zip_ZipTogetherTwoIntListsOfDifferentLengths_ReturnExpectedList()
        {
            List<int> odd = new List<int>() { 1, 3, 5, 7 };
            List<int> even = new List<int>() { 2, 4, 6 };
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // Arrange
            List<int> result;

            // Act
            result = odd.Zip(even);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }



    }
}


    
