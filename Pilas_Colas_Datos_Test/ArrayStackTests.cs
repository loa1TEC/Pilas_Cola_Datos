using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilas_Cola_Datos;

namespace Pilas_Cola_Datos.Tests
{
    [TestClass]
    public class ArrayStackTests
    {
        [TestMethod]
        public void Push_Element_ShouldBeOnTop()
        {
            ArrayStack stack = new ArrayStack(5);
            stack.Push(10);
            stack.Push(20);

            Assert.AreEqual(20, stack.Peek(), "El elemento en la cima debería ser 20.");
        }

        [TestMethod]
        public void Pop_Element_ShouldReturnAndRemoveTop()
        {
            ArrayStack stack = new ArrayStack(5);
            stack.Push(10);
            stack.Push(20);
            int popped = stack.Pop();

            Assert.AreEqual(20, popped, "El elemento eliminado debería ser 20.");
            Assert.AreEqual(10, stack.Peek(), "El nuevo tope debería ser 10.");
        }

        [TestMethod]
        public void Pop_EmptyStack_ShouldReturnUnderflow()
        {
            ArrayStack stack = new ArrayStack(5);
            int popped = stack.Pop();

            Assert.AreEqual(-1, popped, "Pop en una pila vacía debería devolver -1.");
        }

        [TestMethod]
        public void Peek_EmptyStack_ShouldReturnUnderflow()
        {
            ArrayStack stack = new ArrayStack(5);
            int top = stack.Peek();

            Assert.AreEqual(-1, top, "Peek en una pila vacía debería devolver -1.");
        }

        [TestMethod]
        public void IsEmpty_NewStack_ShouldReturnTrue()
        {
            ArrayStack stack = new ArrayStack(5);
            Assert.IsTrue(stack.IsEmpty(), "Una nueva pila debería estar vacía.");
        }

        [TestMethod]
        public void IsFull_StackWithMaxElements_ShouldReturnTrue()
        {
            ArrayStack stack = new ArrayStack(3);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.IsTrue(stack.IsFull(), "La pila debería estar llena después de agregar 3 elementos.");
        }

        [TestMethod]
        public void IsFull_StackWithLessThanMax_ShouldReturnFalse()
        {
            ArrayStack stack = new ArrayStack(3);
            stack.Push(10);
            stack.Push(20);

            Assert.IsFalse(stack.IsFull(), "La pila no debería estar llena con menos de 3 elementos.");
        }
    }
}
