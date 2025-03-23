using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pilas_Cola_Datos;

namespace Pilas_Cola_Datos.Tests
{
    [TestClass]
    public class ArrayQueueTests
    {
        [TestMethod]
        public void Enqueue_Elements_ShouldStoreCorrectly()
        {
            ArrayQueue queue = new ArrayQueue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);

            Assert.AreEqual(10, queue.Front(), "El primer elemento debería ser 10.");
        }

        [TestMethod]
        public void Dequeue_ShouldRemoveAndReturnFront()
        {
            ArrayQueue queue = new ArrayQueue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            int dequeued = queue.Dequeue();

            Assert.AreEqual(10, dequeued, "El elemento eliminado debería ser 10.");
            Assert.AreEqual(20, queue.Front(), "El nuevo frente debería ser 20.");
        }

        [TestMethod]
        public void Dequeue_EmptyQueue_ShouldReturnUnderflow()
        {
            ArrayQueue queue = new ArrayQueue(5);
            int dequeued = queue.Dequeue();

            Assert.AreEqual(-1, dequeued, "Dequeue en una cola vacía debería devolver -1.");
        }

        [TestMethod]
        public void Front_EmptyQueue_ShouldReturnUnderflow()
        {
            ArrayQueue queue = new ArrayQueue(5);
            int front = queue.Front();

            Assert.AreEqual(-1, front, "Front en una cola vacía debería devolver -1.");
        }

        [TestMethod]
        public void IsEmpty_NewQueue_ShouldReturnTrue()
        {
            ArrayQueue queue = new ArrayQueue(5);
            Assert.IsTrue(queue.IsEmpty(), "Una nueva cola debería estar vacía.");
        }

        [TestMethod]
        public void IsEmpty_AfterEnqueue_ShouldReturnFalse()
        {
            ArrayQueue queue = new ArrayQueue(5);
            queue.Enqueue(10);

            Assert.IsFalse(queue.IsEmpty(), "La cola no debería estar vacía después de un enqueue.");
        }
    }
}
