namespace ConsoleApplication7
{
    public class MainString
    {
        char[] new_string = null;
      
        #region Construct
        public MainString()
        {
        }
        public MainString(char a, int b)
        {
            if (b < 0)
                b = 0;
            New_string = new char[b];
            for (int i = 0; i < b; i++)
            {
                New_string[i] = a;
            }
        }
        public MainString(char[] a)
        {
           
            New_string = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                New_string[i] = a[i];
            }            
        }
        public MainString(char[] a, int b, int c)
        {
            if (a == null || b < 0 || c < 0 || b + c > a.Length)
            {
                new_string= new char[0];
                
                return;
            }
            New_string = new char[c];
            
            for ( int i = b,j =0; i < c; i++,j++)
            {
                New_string[i] = a[j];
            }
            
        }
        #endregion
        #region Property 
        public char[] New_string
        {
            get { return new_string; }
            set { new_string = value; }
        }

        public int Length
        {           
            get
            {
                if (New_string == null)
                {
                    return 0;
                }
                return New_string.Length;
            }
        }
        #endregion
        #region Methods
        public char Char_index(int a)
        {
            if (a < 0 || a >= New_string.Length)
                return '"';
            return New_string[a];
        }

        public char[] Concat( char [] a)
        {
            char[] new_Concat = new char[New_string.Length+a.Length];           
            for (int i = 0; i < New_string.Length; i++)
            {
                new_Concat[i] = New_string[i];
            }
            for (int j = 0; j < a.Length; j++)
            {
                new_Concat[New_string.Length + j] = a[j];
            }
            
            return new_Concat;
        }

        public MainString Concat(MainString ob)
        {
            MainString ozz = new MainString();
            ozz.New_string = new char[New_string.Length+ob.Length];
            for (int i = 0; i < New_string.Length; i++)
            {
                ozz.New_string[i] = New_string[i];
            }
            for (int j = 0; j < ob.Length; j++)
            {
                ozz.New_string[New_string.Length + j] = ob.New_string[j];
            }
            return  ozz;
        }

        public MainString Copy(MainString ob)
        {
            MainString ozz=new MainString();
            if (ob == null)
                return  null;
            if (ob.new_string == null)
            {
                ozz.new_string = null;
                return ozz;
            }
            ozz = new MainString(ob.new_string);            
            return ozz;
        }

       public int Indexof (char a, int start_Index)
        {
            if (start_Index < 0)
            {
                return -1;
            }
            for (int i = start_Index; i < new_string.Length; i++)
            {
                if (new_string[i]==a)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Indexof(char a)
        {
            for (int i = 0; i < new_string.Length; i++)
            {
                if (new_string[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Indexof(char a, int start_Index,int count)
        {
            if (start_Index < 0|| count<0||start_Index>new_string.Length||count> new_string.Length-start_Index)
            {
                return -1;
            }
            for (int i = start_Index; i < count; i++)
            {
                if (new_string[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion
    }
}