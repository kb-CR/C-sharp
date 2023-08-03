class Separator
{
    private char glyph;
    private long rune;
  
    public Separator ( long rune )
    {
        this.Rune = rune;
    }
  
    public Separator ( char glyph )
    {
        this.Glyph = glyph;
    }
  
    public char Glyph
    {
        get
        {
            return Convert.ToChar ( this.rune );
        }
        set
        {
            this.glyph = value;
            this.rune = Convert.ToInt64 ( value );
        }
    }

    public long Rune
    {
        get
        {
            return Convert.ToInt64 ( this.glyph );
        }
        set
        {
            this.rune = value;
            this.glyph = Convert.ToChar ( value );

        }
    }

    public object [ ] Separate ( object fore )
    {
        if ( fore is not null )
        {
            string aft= fore.ToString ( )!;
            if ( String.IsNullOrEmpty ( aft ) == false )
            {
                return aft.Split ( this.glyph );
            }
        }
        return Array.Empty<object> ( );
    }

    public object Join ( object [ ] aft )
    {
        return String.Join ( this.glyph , aft );
    }
}
