using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilas_Cola_Datos;

namespace Pilas_Cola_Datos.Tests
{
    [TestClass]
    public class LinkedListStackTests
    {
        [TestMethod]
        public void Push_Element_ShouldBeOnTop()
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);
            stack.Push(20);

            Assert.AreEqual(20, stack.Peek(), "El elemento en la cima debería ser 20.");
        }

        [TestMethod]
        public void Pop_Element_ShouldReturnAndRemoveTop()
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);
            stack.Push(20);
            int popped = stack.Pop();

            Assert.AreEqual(20, popped, "El elemento eliminado debería ser 20.");
            Assert.AreEqual(10, stack.Peek(), "El nuevo tope debería ser 10.");
        }

        [TestMethod]
        public void Pop_EmptyStack_ShouldReturnUnderflow()
        {
            LinkedListStack stack = new LinkedListStack();
            int popped = stack.Pop();

            Assert.AreEqual(-1, popped, "Pop en una pila vacía debería devolver -1.");
        }

        [TestMethod]
        public void Peek_EmptyStack_ShouldReturnUnderflow()
        {
            LinkedListStack stack = new LinkedListStack();
            int top = stack.Peek();

            Assert.AreEqual(-1, top, "Peek en una pila vacía debería devolver -1.");
        }

        [TestMethod]
        public void IsEmpty_NewStack_ShouldReturnTrue()
        {
            LinkedListStack stack = new LinkedListStack();
            Assert.IsTrue(stack.IsEmpty(), "Una nueva pila debería estar vacía.");
        }

        [TestMethod]
        public void IsEmpty_AfterPush_ShouldReturnFalse()
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty(), "La pila no debería estar vacía después de agregar un elemento.");
        }

        [TestMethod]
        public void IsEmpty_AfterPushAndPop_ShouldReturnTrue()
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty(), "La pila debería estar vacía después de agregar y eliminar un elemento.");
        }
    }
}
