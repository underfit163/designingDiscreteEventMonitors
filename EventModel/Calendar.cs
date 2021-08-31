using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventModel
{
    class Calendar
    {
        private CalendarNode _head;

        internal CalendarNode Head
        {
            get
            {
                return _head;
            }

            set
            {
                _head = value;
            }
        }

        public Calendar()
        {
            _head = new CalendarNode();
            _head.Next = _head;
            _head.Prev = _head;
        }

        public void AddEventLast(string label, EventsModel ev, Priorities priority, double time)
        {
            CalendarNode p = new CalendarNode(label, time, ev, priority);
            CalendarNode q = Head;
            while (q.Next != Head && q.Next.Priority>=priority)
            {
                q = q.Next;
            }
            p.Next = q.Next;
            p.Prev = q;
            q.Next.Prev = p;
            q.Next = p;
        }
        //добавление после
        public void AddEventAfter(string label, EventsModel evAdd, Priorities priority, double time, EventsModel evAfter)
        {
            CalendarNode p = new CalendarNode(label, time, evAdd, priority);
            CalendarNode q = Head;
            if (priority != Priorities.NoPriority)
            {
                while (q.Priority > priority && q.Next != Head)
                {
                    q = q.Next;
                }
                if (q.Priority == priority)
                {
                    while (q.Ev != evAfter && q.Priority == priority)
                    {
                        q = q.Next;
                    }
                    if (q.Ev == evAfter)
                    {
                        p.Next = q.Next;
                        p.Prev = q;
                        q.Next.Prev = p;
                        q.Next = p;
                    }
                }
                else
                    AddEventLast(label, evAdd, priority, time);
            }
        }

        public void cancelByEvent(EventsModel evDelete)
        {
            if (!isNull)
            {
                CalendarNode q = Head;
                while (q.Next != Head)
                {
                    q = q.Next;
                    if (q.Ev == evDelete)
                    {
                        q = q.Prev;
                        q.Next.Next.Prev = q;
                        q.Next = q.Next.Next;
                    }
                }
            }
        }
        //удаление 
        public void cancelOne(CalendarNode p)
        {
            if (!isNull)
            {
                CalendarNode q = Head;
                while (q.Next != Head && q != p)
                {
                    q = q.Next;
                }
                q = q.Prev;
                q.Next = q.Next.Next;
                q.Next.Prev = q;
            }
        }
        //получение времени и приоритета
        public double getTimeAndPriority(EventsModel ev, double time, out Priorities priority)
        {
            if (!isNull)
            {
                CalendarNode p = Head;
                if (p.Next.Ev != ev)
                {
                    while (p.Next.Ev != ev && p.Next!=Head)
                    {
                        p = p.Next;
                        time += p.TimeAct;
                    }
                    if (p.Next == Head)
                    {
                        priority = Priorities.NoPriority;
                        return 0;
                    }
                }
                priority = p.Next.Priority;
                time += p.Next.TimeAct;
                return time;
            } 
            priority = Priorities.NoPriority;
            return 0;
        }
        //изменение приоритета
        public void changePriority(EventsModel ev, Priorities priorityEv,Priorities priority)
        {
            if (priorityEv != priority)
            {
                CalendarNode p = Head;
                while (p.Next != Head &&  p.Ev != ev && p.Priority != priorityEv)
                {
                    p = p.Next;
                }
                if (p.Ev == ev && p.Priority == priorityEv)
                {
                    CalendarNode paste = p;
                    cancelOne(p);
                    paste.Priority = priority;
                    AddEventLast(paste.LabelName, paste.Ev, paste.Priority, paste.TimeAct);
                }
            }
        }

        public int Length
        {
            get
            {
                int i = 0;
                CalendarNode p = Head;
                while (p.Next != Head)
                {
                    i++;
                    p = p.Next;
                }
                return i;
            }
        }

        public bool isNull
        {
            get
            {
                return (Head.Next == Head);
            }
        }
    }
}
