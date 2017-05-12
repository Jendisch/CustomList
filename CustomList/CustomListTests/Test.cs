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
        public void ToString_OverrideOriginalToStringUsingInt_ReturnStringWithPeriodAndSpaceAdded()
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

        [TestMethod]
        public void ToString_OverrideOriginalToStringUsingAListOfStringLists_ReturnStringWithPeriodAndSpaceAdded()
        {
            // Arrange
            List<string> list1 = new List<string>() { "I", "Love", "Putting" };
            List<string> list2 = new List<string>() { "Periods", "Between" };
            List<string> list3 = new List<string>() { "Words" };
            List<string> list4 = new List<string>() { "For", "Emphasis" };
            List<List<string>> listOfLists = new List<List<string>>() { list1, list2, list3, list4 };

            // Arrange
            string expected = "I. Love. Putting. Periods. Between. Words. For. Emphasis";
            string result;

            // Act
            result = listOfLists.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }



        //OverLoad + Operator Tests



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



        //OverLoad - Operator Tests



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

        [TestMethod]
        public void Zip_ZipTogetherTwoStringLists_ReturnExpectedList()
        {
            List<string> love = new List<string>() { "You", "love", "they", "THE" };
            List<string> tacos = new List<string>() { "gotta", "tacos", "are", "best" };
            List<string> expected = new List<string>() { "You", "gotta", "love", "tacos", "they", "are", "THE", "best" };
            // Arrange
            List<string> result;

            // Act
            result = love.Zip(tacos);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Zip_ZipTogetherOneListWithAnotherEmptyList_ReturnExpectedEmptyList()
        {
            // Arrange
            List<int> odd = new List<int>() { 1, 3, 5 };
            List<int> empty = new List<int>();
            List<int> expected = new List<int>();
            List<int> result;

            // Act
            result = odd.Zip(empty);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }



        //SortAscending Tests



        [TestMethod]
        public void SortAscending_SortTheIntListInAscendingOrder_MakeSureListIsInExpectedOrder()
        {
            // Arrange
            List<int> list = new List<int> { 4, 6, 4, 2, 8, 5, 9, 0, 1, 2 };
            List<int> expected = new List<int> { 0, 1, 2, 2, 4, 4, 5, 6, 8, 9 };

            // Act
            list.SortAscending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortAscending_SortTheIntListInAscendingOrderWithDoubleDigits_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<int> list = new List<int> { 24, 20, 33, 19, 22 };
            List<int> expected = new List<int> { 19, 20, 22, 24, 33 };

            // Act
            list.SortAscending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortAscending_SortTheStringListInAscendingOrder_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<string> list = new List<string> { "g", "d", "c", "f", "a", "e", "b" };
            List<string> expected = new List<string> { "a", "b", "c", "d", "e", "f", "g" };

            // Act
            list.SortAscending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortAscending_SortTheStringOfWordsListInAscendingOrder_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<string> list = new List<string> { "github", "zaza", "door", "apple", "douchebag", "ape" };
            List<string> expected = new List<string> { "ape", "apple", "door", "douchebag", "github", "zaza" };

            // Act
            list.SortAscending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }



        //SortDescending Tests



        [TestMethod]
        public void SortDescending_SortTheIntListInDescendingOrder_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<int> list = new List<int> { 4, 6, 4, 2, 8, 5, 9, 0, 1, 2 };
            List<int> expected = new List<int> { 9, 8, 6, 5, 4, 4, 2, 2, 1, 0, };

            // Act
            list.SortDescending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortDescending_SortTheIntListInDescendingOrderWithDoubleDigits_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<int> list = new List<int> { 24, 20, 33, 19, 22 };
            List<int> expected = new List<int> { 33, 24, 22, 20, 19 };

            // Act
            list.SortDescending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortDescending_SortTheStringListInDescendingOrder_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<string> list = new List<string> { "d", "g", "c", "f", "a", "e", "b" };
            List<string> expected = new List<string> { "g", "f", "e", "d", "c", "b", "a" };

            // Act
            list.SortDescending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }

        [TestMethod]
        public void SortDescending_SortTheStringOfWordsListInDescendingOrder_MakeSureReturnListIsInExpectedOrder()
        {
            // Arrange
            List<string> list = new List<string> { "github", "zaza", "door", "apple", "douchebag", "ape" };
            List<string> expected = new List<string> { "zaza", "github", "douchebag", "door", "apple", "ape" };

            // Act
            list.SortDescending();

            // Assert
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i]);
            }
        }



        //Other Methods Needed Tests



        [TestMethod]
        public void FindIfListWithLengthOfOneHasItemWeAreLookingFor_ListDoesntHaveIt_ReturnFalse()
        {
            List<int> list = new List<int>() { 10 };
            // Arrange
            int item = 5;
            bool result;

            // Act
            result = list.FindIfListWithLengthOfOneHasItemWeAreLookingFor(item);

            // Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckTheIndex_NotSatisfyFunction_ExpectNewArgumentException()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //Arrange
            int i = 6;
            int result;

            //Act
            result = list.CheckTheIndex(i);

            //Assert 
        }

        [TestMethod]
        public void ConvertItemToString_ConvertListItemToString_ReturnIntZeroForItemsBeingEqual()
        {
            //Arrange
            List<int> list1 = new List<int>() { 10 };
            List<int> list2 = new List<int>() { 10 };
            int expected = 0;
            int result;

            //Act
            result = list1.ConvertItemToString(list1[0], list2[0]);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertItemToString_ConvertListItemToString_ReturnIntNegativeOneForItemsBeingEqual()
        {
            //Arrange
            List<int> list1 = new List<int>() { 10 };
            List<int> list2 = new List<int>() { 5 };
            int expected = -1;
            int result;

            //Act
            result = list1.ConvertItemToString(list1[0], list2[0]);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
