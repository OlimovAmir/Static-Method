namespace Static_Method
{
    internal class Counter
    {
        public Counter()
        {
            counter++;
        }
        private static int counter;

		public static int CounterProperty
		{
			get { return counter; }
            private 	set { counter = value; }
		}

        public static int GetCounted()
        {
            return counter;
        }
	}
}
