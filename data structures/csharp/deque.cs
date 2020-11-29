using System;

namespace learning.data_structures {
    public class Deque<T> {
        private T[] data = Array.Empty<T>();
        public int Capacity;
        public int IndexFirst;
        public int IndexLast;
    }
}