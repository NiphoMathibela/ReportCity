using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class MinHeap
    {
        private List<IssueModel> heap = new List<IssueModel>();

        public void Insert(IssueModel issue)
        {
            heap.Add(issue);
            HeapifyUp(heap.Count - 1);
        }

        public IssueModel RemoveMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty");
            IssueModel min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index].Priority < heap[parentIndex].Priority)
                {
                    // Swap
                    IssueModel temp = heap[index];
                    heap[index] = heap[parentIndex];
                    heap[parentIndex] = temp;

                    // Move up the tree
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (index <= lastIndex)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int smallestIndex = index;

                if (leftChildIndex <= lastIndex && heap[leftChildIndex].Priority < heap[smallestIndex].Priority)
                {
                    smallestIndex = leftChildIndex;
                }

                if (rightChildIndex <= lastIndex && heap[rightChildIndex].Priority < heap[smallestIndex].Priority)
                {
                    smallestIndex = rightChildIndex;
                }

                if (smallestIndex == index)
                {
                    break; // The heap is valid
                }

                // Swap
                IssueModel temp = heap[index];
                heap[index] = heap[smallestIndex];
                heap[smallestIndex] = temp;

                // Move down the tree
                index = smallestIndex;
            }
        }
    }
}
