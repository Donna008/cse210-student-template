public abstract class Player
    {
        protected char _symbol;
        public abstract Move MakeMove(Board board);
        public char Symbol => _symbol;
    }
