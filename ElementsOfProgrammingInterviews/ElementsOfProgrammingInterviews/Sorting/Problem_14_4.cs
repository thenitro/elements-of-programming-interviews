using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Sorting
{
    public class Problem_14_4
    {
        public int Solution(Tuple<int, int>[] schedule)
        {
            var events = new List<Event>();

            for (var i = 0; i < schedule.Length; i++)
            {
                events.Add(new Event(true, schedule[i].Item1));
                events.Add(new Event(false, schedule[i].Item2));
            }
            
            events.Sort((a, b) => a.Time.CompareTo(b.Time) == 0 ? a.IsStart.CompareTo(b.IsStart) : a.Time.CompareTo(b.Time));

            var maxEvents = int.MinValue;
            var currentEvents = 0;
            
            for (var i = 0; i < events.Count; i++)
            {
                if (events[i].IsStart)
                {
                    currentEvents++;
                    maxEvents = Math.Max(maxEvents, currentEvents);
                }
                else
                {
                    currentEvents--;
                }
            }

            return maxEvents;
        }

        private class Event
        {
            public bool IsStart { get; private set; }
            public int Time { get; private set; }
            
            public Event(bool isStart, int time)
            {
                IsStart = isStart;
                Time = time;
            }
        }
    }
}