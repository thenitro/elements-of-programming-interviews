using System;
using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_4
    {
        private int _k;
        private MinHeap<Planet> _heap;
        
        public Problem_11_4(int k)
        {
            _k = k;
            _heap = new MinHeap<Planet>();
        }

        public List<Planet> SolutionStream(Planet planet)
        {
            var distance = planet.DistanceToEarth();

            if (_heap.Count == 0)
            {
                _heap.Push(-distance, planet);
            }
            else
            {
                if (distance < Math.Abs(_heap.Peek().Priority))
                {
                    if (_heap.Count == _k)
                    {
                        _heap.Pop();
                    }
                    
                    _heap.Push(-distance, planet);
                }
            }

            return _heap.ToList();
        }
    }

    public class Planet
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _z;

        public Planet(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double DistanceToEarth()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }
    }
}