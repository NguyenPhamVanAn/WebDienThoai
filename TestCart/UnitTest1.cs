using NUnit.Framework;
using WebBanHang.Models;

namespace TestCart
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
            Assert.Pass();
        }

        [Test]
        public void Can_Add_To_Cart()
        {
            Product p1 = new Product { Id = 1, Name = "A" };
            Product p2 = new Product { Id = 2, Name = "B" };
            Product p3 = new Product { Id = 1, Name = "C" };

            Cart cart = new Cart();
            cart.Add(p1, 1);
            cart.Add(p2, 1);
            cart.Add(p3, 3);

            CartItem[] _items = cart.Items.ToArray();
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            Assert.AreEqual(p2, _items[1].Product);
           
            Assert.AreEqual(4, _items[0].Quantity);
          
            // Assert.AreEqual(p3, _items[2].Product);
        }

        [Test]
        public void Can_Remove_To_Cart()
        {
            Product p1 = new Product { Id = 1, Name = "A" };
            Product p2 = new Product { Id = 2, Name = "B" };
          

            Cart cart = new Cart();
            cart.Add(p1, 1);
            cart.Add(p2, 1);
           

            CartItem[] _items = cart.Items.ToArray();
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            Assert.AreEqual(p2, _items[1].Product);

            cart.Remove(2);
            _items = cart.Items.ToArray();
            Assert.AreEqual(1, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            // Assert.AreEqual(p3, _items[2].Product);
        }

        [Test]
        public void Can_Update_To_Cart()
        {
            Product p1 = new Product { Id = 1, Name = "A" };
            Product p2 = new Product { Id = 2, Name = "B" };


            Cart cart = new Cart();
            cart.Add(p1, 1);
            cart.Add(p2, 1);


            CartItem[] _items = cart.Items.ToArray();
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(p1, _items[0].Product);
            Assert.AreEqual(p2, _items[1].Product);

            cart.Update(2, 5);
            _items = cart.Items.ToArray();
            Assert.AreEqual(2, _items.Length);
            Assert.AreEqual(5, _items[1].Quantity);
            // Assert.AreEqual(p3, _items[2].Product);
        }
    }
}