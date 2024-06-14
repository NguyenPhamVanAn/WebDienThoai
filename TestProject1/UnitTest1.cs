using NUnit.Framework;
using System.Collections.Generic;
using WebBanHang.Models;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

        }
        [Test]
        public void Can_Add_New_Lines()
        {
            // Arrange - create some test products
            Product p1 = new Product { Id = 1, Name = "P1" };
            Product p2 = new Product { Id = 1, Name = "P2" };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Act
            target.Add(p1, 1);
            target.Add(p2, 1);
            CartItem[] _items = target.Items.ToArray();
            // Assert
            Assert.AreEqual(1, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
           // Assert.AreEqual(p2, _items[1].Product);
        }

        [Test]
        public void Can_Remove()
        {
            // Arrange - create some test products
            Product p1 = new Product { Id = 1, Name = "P1" };
            Product p2 = new Product { Id = 2, Name = "P2" };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Act
            target.Add(p1, 1);
            target.Add(p2, 1);
            CartItem[] _items = target.Items.ToArray();
            // Assert
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            Assert.AreEqual(p2, _items[1].Product);
            target.Remove(1);
            _items = target.Items.ToArray();
            Assert.AreEqual(p2, _items[0].Product);
        }

        [Test]
        public void Can_Update()
        {
            // Arrange - create some test products
            Product p1 = new Product { Id = 1, Name = "P1" };
            Product p2 = new Product { Id = 2, Name = "P2" };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Act
            target.Add(p1, 1);
            target.Add(p2, 1);
            CartItem[] _items = target.Items.ToArray();
            // Assert
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            Assert.AreEqual(p2, _items[1].Product);
            target.Update(1, 0);
            _items = target.Items.ToArray();
            Assert.AreEqual(1, _items.Length);
           // Assert.AreEqual(1, _items[0].Quantity);
        }
    }
}