using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilas_Cola_Datos;

namespace Pilas_Cola_Datos.Tests
{
    [TestClass]
    public class LinkedListQueueTests
    {
        [TestMethod]
        public void Enqueue_Element_ShouldBeAtFront()
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);

            Assert.AreEqual(10, queue.Front(), "El primer elemento en la cola debería ser 10.");
        }

        [TestMethod]
        public void Dequeue_Element_ShouldReturnAndRemoveFront()
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            int dequeued = queue.Dequeue();

            Assert.AreEqual(10, dequeued, "El elemento eliminado debería ser 10.");
            Assert.AreEqual(20, queue.Front(), "El nuevo frente debería ser 20.");
        }

        [TestMethod]
        public void Dequeue_EmptyQueue_ShouldReturnUnderflow()
        {
            LinkedListQueue queue = new LinkedListQueue();
            int dequeued = queue.Dequeue();

            Assert.AreEqual(-1, dequeued, "Dequeue en una cola vacía debería devolver -1.");
        }

        [TestMethod]
        public void Front_EmptyQueue_ShouldReturnUnderflow()
        {
            LinkedListQueue queue = new LinkedListQueue();
            int front = queue.Front();

            Assert.AreEqual(-1, front, "Front en una cola vacía debería devolver -1.");
        }
    }
}
