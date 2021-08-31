
namespace EventModel
{
    enum EventsModel
    {
        EV1,
        EV2,
        EV3,
        EV4,
        EV5,
        NoEvent
    }
    
    enum Priorities
    {
        Low,
       LessThanNormal,
        Normal,
       MoreThanNormal,
        High,
        NoPriority
    }
    class CalendarNode
    {
        private string _labelName;
        private CalendarNode _next;
        private CalendarNode _prev;
        private EventsModel _ev;
        private double _timeAct;
        private Priorities _priority;
        private string _addictionInfo;

        internal CalendarNode Next
        {
            get
            {
                return _next;
            }

            set
            {
                _next = value;
            }
        }

        internal CalendarNode Prev
        {
            get
            {
                return _prev;
            }

            set
            {
                _prev = value;
            }
        }

        internal EventsModel Ev
        {
            get
            {
                return _ev;
            }

            set
            {
                _ev = value;
            }
        }

        public double TimeAct
        {
            get
            {
                return _timeAct;
            }

            set
            {
                _timeAct = value;
            }
        }

        internal Priorities Priority
        {
            get
            {
                return _priority;
            }

            set
            {
                _priority = value;
            }
        }

        public string AddictionInfo
        {
            get
            {
                return _addictionInfo;
            }

            set
            {
                _addictionInfo = value;
            }
        }

        public string LabelName
        {
            get
            {
                return _labelName;
            }

            set
            {
                _labelName = value;
            }
        }

        public CalendarNode()
        {
            LabelName = "";
            Next = null;
            Prev = null;
            TimeAct = 0;
            Ev = EventsModel.NoEvent;
            AddictionInfo = "";
            Priority = Priorities.NoPriority;
        }
      
        public CalendarNode(string labelName, double timeAct, EventsModel ev, Priorities priority)
        {
            LabelName = labelName;
            Next = null;
            Prev = null;
            TimeAct = timeAct;
            Ev = ev;
            Priority = priority;
        }
    }
}
