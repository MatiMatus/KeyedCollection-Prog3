using KeyedCollection;

namespace KeyedCollectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertarElemento()
        {
            SimpleOrder weekly = new SimpleOrder();
            weekly.Add(new OrderItem(110072674, "Widget"));
            weekly.Add(new OrderItem(110072675, "Sprocket"));
            weekly.Add(new OrderItem(101030411, "Motor"));
            weekly.Add(new OrderItem(110072684, "Gear"));

            Assert.Equal("Widget", weekly[110072674].Description);
            Assert.Equal("Motor", weekly[101030411].Description);
            //Assert.Equal("Sprocket", weekly[101030411].Description);
        }
        [Fact]
        public void EliminarElementoColeccion()
        {
            SimpleOrder weekly = new SimpleOrder();
            weekly.Add(new OrderItem(110072674, "Widget"));
            weekly.Add(new OrderItem(110072675, "Sprocket"));
            weekly.Remove(110072674);
            Assert.False(weekly.Contains(110072674));
            //Assert.False(weekly.Contains(110072675));
        }
        [Fact] 
        public void EliminarContenidoCollecion()
        {
            SimpleOrder weekly = new SimpleOrder();
            weekly.Add(new OrderItem(110072674, "Widget"));
            weekly.Add(new OrderItem(110072675, "Sprocket"));
            weekly.Clear();
            Assert.Empty(weekly);
            //
            weekly.Add(new OrderItem(110072684, "Gear"));
            //Assert.Empty(weekly);
        }
        [Fact]
        public void InsertarEnMismaPosicion()
        {
            SimpleOrder weekly = new SimpleOrder();
            weekly.Add(new OrderItem(110072674, "Widget"));
            weekly.Add(new OrderItem(110072675, "Sprocket"));
            weekly.Add(new OrderItem(101030411, "Motor"));
            weekly.Add(new OrderItem(110072684, "Gear"));
            //
            Assert.True(weekly.Contains(101030411));
            //
            Assert.Equal("Motor", weekly[101030411].Description);
            //
            weekly.Remove(101030411);
            Assert.False(weekly.Contains(101030411));
            //
            weekly.Insert(2, new OrderItem(111033401, "Nut"));
            Assert.Equal("Nut", weekly[111033401].Description);
            //
            //Assert.Equal("Motor", weekly[101030411].Description);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void InsertMasivo(int cantidad)
        {
            SimpleOrder weekly = new SimpleOrder();
            for (int i = 0; i < cantidad; i++)
            {
                weekly.Add(new OrderItem(i, "Widget"));
            }
            //
            Assert.Equal("Widget", weekly[1].Description);            
            Assert.Equal(cantidad, weekly.Count);
        }
    }
}