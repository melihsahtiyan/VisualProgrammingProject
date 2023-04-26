namespace Core.Persistence.Dynamic;

    public class Dynamic
    {
        public Filter Filter { get; set; }
        public IEnumerable<Sort> Sort { get; set; }

        public Dynamic()
        {
        }

        public Dynamic(Filter filter, IEnumerable<Sort> sorts)
        {
            Filter = filter;
            Sort = sorts;
        }
    }

