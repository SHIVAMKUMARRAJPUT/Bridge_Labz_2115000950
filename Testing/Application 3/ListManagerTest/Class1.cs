using ListOperation;
using NUnit.Framework;
using System.Collections.Generic;
using ListOperation;
namespace ListManagerTest
{

   
[TestFixture]
    public class ListManagerTests{


   
        private ListManager _listManager;
        private List<int> _list;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _list = new List<int> { 1, 2, 3 };
        }

        [Test]
        public void AddElement_GivenElement_AddsElementToList()
        {
            int element = 4;
            _listManager.AddElement(_list, element);
            Assert.That(_list, Does.Contain(element));
        }

        [Test]
        public void RemoveElement_GivenElement_RemovesElementFromList()
        {
            int element = 2;
            _listManager.RemoveElement(_list, element);
            Assert.That(_list, Does.Not.Contain(element));
        }

        [Test]
        public void GetSize_AfterAddingElement_ReturnsUpdatedSize()
        {
            _listManager.AddElement(_list, 4);
            int size = _listManager.GetSize(_list);
            Assert.That(size, Is.EqualTo(4));
        }

        [Test]
        public void GetSize_AfterRemovingElement_ReturnsUpdatedSize()
        {
            _listManager.RemoveElement(_list, 2);
            int size = _listManager.GetSize(_list);
            Assert.That(size, Is.EqualTo(2));
        }
    }





}
