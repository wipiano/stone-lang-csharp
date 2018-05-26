namespace Stone
{
    public abstract class Token
    {
        public static readonly Token EOF = new EOFToken();
        public static readonly string EOL = "\\n";
        
        public int LineNumber { get; }
        
        protected Token(int lineNumber)
        {
            LineNumber = lineNumber;
        }

        public virtual bool IsIdentifier => false;

        public virtual bool IsNumber => false;

        public virtual bool IsString => false;
        
        public virtual int GetNumber() => throw new StoneException("not number token");

        public virtual string GetText() => string.Empty;


        private sealed class EOFToken : Token
        {
            public EOFToken()
                : base (-1)
            {}
        }
    }
}