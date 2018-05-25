namespace Stone
{
    public abstract class Token
    {
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
    }
}