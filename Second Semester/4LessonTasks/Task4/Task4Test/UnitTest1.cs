using System;
using System.Security.Cryptography.X509Certificates;
using Task4;

namespace Task4Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(-2)]
        [TestCase(-3)]
        [TestCase(-4)]
        [TestCase(-5)]
        public void NegativeNumbers(int number)
        {
            PrimeTool primeTool = new PrimeTool(number);

            bool ret = primeTool.IsPrime();

            Assert.That(false, Is.EqualTo(ret));
        }
        [TestCase(0)]
        [TestCase(1)]

        public void SpecialNumber(int number)
        {

            PrimeTool primeTool = new PrimeTool(number);

            bool ret = primeTool.IsPrime();

            Assert.That(false, Is.EqualTo(ret));

        }

        [TestCase(4)]
        [TestCase(9)]
        [TestCase(100)]
        public void PositiveNonPrimeNumbers(int number)
        {

            PrimeTool primeTool = new PrimeTool(number);

            bool ret = primeTool.IsPrime();

            Assert.That(false, Is.EqualTo(ret));

        }
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]

        public void PositivePrimeNumbers(int number)
        {

            PrimeTool primeTool = new PrimeTool(number);

            bool ret = primeTool.IsPrime();

            Assert.That(true, Is.EqualTo(ret));

        }

        [TestCase(new int[0], 0)]
        [TestCase(new int[3] { 1, 2, 3 }, 6)]
        public void Total(int[] arr, int res)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);
            //arr[0] = 10; ez miatt kell a .ToArray()

            int temp = arrayStatics.Total();
            Assert.That(res, Is.EqualTo(temp));
        }

        [TestCase(new int[2] { 10, 12 }, 12)]
        [TestCase(new int[3] { 1, 2, 3 }, 3)]
        public void Contains(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            bool temp = arrayStatics.Contains(num);

            Assert.That(true, Is.EqualTo(temp));

        }
        [TestCase(new int[2] { 10, 12 }, 11)]
        [TestCase(new int[3] { 1, 2, 3 }, 6)]
        public void NotContains(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            bool temp = arrayStatics.Contains(num);

            Assert.That(false, Is.EqualTo(temp));

        }
        [TestCase(new int[0])]
        public void SortedIsEmpty(int[] arr)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(false, Is.EqualTo(arrayStatics.Sorted()));
        }

        [TestCase(new int[2] { 10, 12 })]
        [TestCase(new int[3] { 1, 2, 3 })]
        public void SortedIsInAsc(int[] arr)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(true, Is.EqualTo(arrayStatics.Sorted()));
        }


        [TestCase(new int[0], 2)]

        public void FirstGreaterIsEmpty(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(-1, Is.EqualTo(arrayStatics.FirstGreater(num)));
        }


        [TestCase(new int[2] { 10, 12 }, 11)]
        [TestCase(new int[3] { 1, 2, 3 }, 2)]
        public void FirstGreaterHasBigger(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.LessThan(arrayStatics.FirstGreater(num)));

        }

        [TestCase(new int[2] { 10, 12 }, 15)]
        [TestCase(new int[3] { 1, 2, 3 }, 45)]
        public void FirstGreaterHasNotBigger(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.GreaterThan(arrayStatics.FirstGreater(num)));
        }


        [TestCase(new int[2] { 10, 12 }, 2)]
        [TestCase(new int[3] { 10, 100, 6 }, 3)]
        public void HaveCountEvens(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.EqualTo(arrayStatics.CountEvens()));
        }

        [TestCase(new int[2] { 1, 67 }, 0)]
        [TestCase(new int[3] { 1, 9, 3 }, 0)]
        [TestCase(new int[0], 0)]

        public void DontHaveCountEvens(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.EqualTo(arrayStatics.CountEvens()));

        }

        [TestCase(new int[2] { 1, 67 }, 1)]
        [TestCase(new int[3] { 1, 9, 3 }, 1)]

        public void MaxIndexHaveNumbers(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.EqualTo(arrayStatics.MaxIndex()));

        }


        [TestCase(new int[0], 0)]

        public void MaxIndexDouesntHaveNumbers(int[] arr, int num)
        {
            ArrayStatics arrayStatics = new ArrayStatics(arr);

            Assert.That(num, Is.EqualTo(arrayStatics.MaxIndex()));

        }


        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 3, 4, 5, 6 })]
        public void SortMinOrderTrue(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortMinOrder();

            Assert.That(exp, Is.EqualTo(arrayStatics.Numbers));
        }

        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 4, 3, 5, 6 })]
        public void SortMinOrderFalse(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortMinOrder();

            Assert.That(exp, Is.Not.EqualTo(arrayStatics.Numbers));
        }

        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 3, 4, 5, 6 })]
        public void SortMinSelectTrue(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortMinSelect();

            Assert.That(exp, Is.EqualTo(arrayStatics.Numbers));
        }

        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 4, 3, 5, 6 })]
        public void SortMinSelectFalse(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortMinSelect();

            Assert.That(exp, Is.Not.EqualTo(arrayStatics.Numbers));

        }

        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 3, 4, 5, 6 })]
        public void SortInsertionTrue(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortInsertion();

            Assert.That(exp, Is.EqualTo(arrayStatics.Numbers));
        }

        [TestCase(new int[6] { 6, 3, 1, 5, 4, 2 }, new int[6] { 1, 2, 4, 3, 5, 6 })]
        public void SortInsertionFalse(int[] inp, int[] exp)
        {
            ArrayStatics arrayStatics = new ArrayStatics(inp);

            arrayStatics.SortInsertion();

            Assert.That(exp, Is.Not.EqualTo(arrayStatics.Numbers));

        }
        [TestCase(5, 'A', 'B', 'C', 'D', 'E')]
        public void PushRightNums(int num, char char1, char char2, char char3, char char4, char char5)
        {
            Stack stack= new Stack(num);
            bool res = stack.Push(char1);
            bool res2 = stack.Push(char2);
            bool res3 = stack.Push(char3);
            bool res4 = stack.Push(char4);
            bool res5 = stack.Push(char5);

            Assert.That(true, Is.EqualTo(res5));

        }

        [TestCase(5, 'A', 'B', 'C', 'D', 'E', 'F')]
        public void PushMuchNums(int num, char char1, char char2, char char3, char char4, 
                                char char5, char char6)
        {
            Stack stack = new Stack(num);
            bool res = stack.Push(char1);
            bool res2 = stack.Push(char2);
            bool res3 = stack.Push(char3);
            bool res4 = stack.Push(char4);
            bool res5 = stack.Push(char5);
            bool res6 = stack.Push(char6);

            Assert.That(false, Is.EqualTo(res6));

        }

        [TestCase(5, 'A')]
        public void PushONeNum(int num, char char1)
        {
            Stack stack = new Stack(num);

            bool res= stack.Push(char1);

            Assert.That(true, Is.EqualTo(res));


        }

        [TestCase(5, 'A', 'B', 'C', 'D', 'E')]
        public void PopRightNums(int num, char char1, char char2, char char3, char char4, char char5)
        {
            Stack stack = new Stack(num);
            stack.Push(char1);
            stack.Push(char2);
            stack.Push(char3);
            stack.Push(char4);
            stack.Push(char5);

            stack.Pop(out char item);
            stack.Pop(out char item2);
            stack.Pop(out char item3);
            stack.Pop(out char item4);
            bool res = stack.Pop(out char item5);

            Assert.That(true, Is.EqualTo(res));

        }
    }
}