using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Zadanie1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()               //test sprawdzający generator liczb losowych
        {
            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            int x = rng.nextInt(1, 29);
            Assert.IsTrue(x >= 1 && x <= 29);
        }

        [TestMethod]
        public void TestMethod2()               //sprawdzenie czy jeśli co najmniej jeden element spełnia ograniczenia, to zwrócono co najmniej jeden element
        {

            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            List<int> weights = new List<int>();
            List<int> index = new List<int>();
            List<int> values = new List<int>();
            for (int i = 0; i < 1; i++)
                index.Add(i);
            for (int j = 0; j < 1; j++)
                values.Add(rng.nextInt(1, 29));
            for (int k = 0; k < 1; k++)
                weights.Add(5);
            var b1 = new Backpack(50);
            b1.Load(index, values, weights);
            int result = b1.Load_weights;
            Assert.IsTrue(result >= 1);
        }



        [TestMethod]
        public void TestMethod3()               //sprawdzenie czy jeśli żaden element nie spełnia ograniczeń, to zwrócono puste rozwiązanie
        {

            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            List<int> weights = new List<int>();
            List<int> index = new List<int>();
            List<int> values = new List<int>();
            for (int i = 0; i < 1; i++)
                index.Add(i);
            for (int j = 0; j < 1; j++)
                values.Add(rng.nextInt(1, 29));
            for (int k = 0; k < 1; k++)
                weights.Add(52);
            var b1 = new Backpack(50);
            b1.Load(index, values, weights);
            int result = b1.Load_weights;
            Assert.IsTrue(result == 0);
        }


        [TestMethod]
        public void TestMethod4()               //dwa testy sprawdzające czy kolejność przedmiotów ma wpływ na znalezione rozwiązanie
        {

            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            List<int> weights = new List<int>();
            List<int> index = new List<int>();
            List<int> values = new List<int>();
            for (int i = 0; i < 4; i++)
                index.Add(i);
                values.Add(3);
                values.Add(10);
                values.Add(4);
                values.Add(2);
                weights.Add(30);
                weights.Add(25);
                weights.Add(10);
                weights.Add(4);
            var b1 = new Backpack(50);
            b1.Load(index, values, weights);
            Assert.IsTrue(b1.Load_value == 9);
        }



        [TestMethod]
        public void TestMethod5()               //dwa testy sprawdzające czy kolejność przedmiotów ma wpływ na znalezione rozwiązanie
        {

            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            List<int> weights = new List<int>();
            List<int> index = new List<int>();
            List<int> values = new List<int>();
            for (int i = 0; i < 4; i++)
                index.Add(i);
            
            values.Add(10);
            values.Add(4);
            values.Add(2);
            values.Add(3);
            weights.Add(25);
            weights.Add(10);
            weights.Add(4);
            weights.Add(30);
            var b1 = new Backpack(50);
            b1.Load(index, values, weights);
            Assert.IsTrue(b1.Load_value == 16);
        }

    }
}
