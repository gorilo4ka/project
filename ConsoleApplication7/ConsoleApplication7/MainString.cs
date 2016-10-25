namespace Работа_со_строками
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
        public char this[int index]
       {
            set
            {
                new_string[index] = value;
            }

            get
            {
                return new_string[index];
            }
            }
        
       



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
            for (int i = start_Index; i < start_Index+count; i++)
            {
                if (new_string[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(char a)
        {
            int LastIndex = -1;
            for (int i = 0; i < new_string.Length; i++)
            {
                if (a == new_string[i])
                    LastIndex = i;
            }
            return LastIndex;
        }

        public int LastIndexOf(char a,int startIndex)
        {
            int LastIndex = -1;
            if (startIndex<0||startIndex>=new_string.Length)
            {
                return LastIndex;
            }
            for (int i = startIndex; i > 0; i--)
            {
                if (a == new_string[i])
                    LastIndex = startIndex-i;
            }
            return LastIndex;
        }

        public int LastIndexOf(char a, int startIndex,int count)
        {
            int LastIndex = -1;
            if (startIndex < 0 || startIndex >= new_string.Length||startIndex-count+1<0)
            {
                return LastIndex;
            }
            for (int i = startIndex; i > startIndex-count; i--)
            {
                if (a == new_string[i])
                    LastIndex = startIndex - i;
            }
            return LastIndex;
        }

        public char[] Remove(int startIndex)
        {
            char[] Remove_string;
            if (startIndex<0||startIndex>new_string.Length)
            {
                return  new char[0];
            }
            Remove_string = new char[startIndex];
            for (int i = 0; i < startIndex  ; i++)
            {
                Remove_string[i] = new_string[i];
            }
            return Remove_string;
        }


        public char[] Remove(int startIndex,int count)
        {
            char[] Remove_string;
            if (startIndex < 0||count<0 || startIndex > new_string.Length||startIndex+count>new_string.Length)
            {
                return  new char[0];
            }
            Remove_string = new char[new_string.Length-count];
            for (int i = 0; i < startIndex; i++)
            {
                Remove_string[i] = new_string[i];
            }
            for (int    j = startIndex; j < Remove_string.Length; j++)
            {
                Remove_string[j] = new_string[j+count];
            }
            return Remove_string;
        }

        public char[] Replace(char oldChar,char newChar)
        {
            char[] Replace_string;
            Replace_string = new char[new_string.Length];
            for (int i = 0; i < Replace_string.Length; i++)
            {
                Replace_string[i] = new_string[i];
            }
            for (int i = 0; i < Replace_string.Length; i++)
            {
                if (Replace_string[i]==oldChar)
                {
                    Replace_string[i] = newChar;
                }
            }
            return Replace_string;
        }

        public static MainString operator +(MainString object1,MainString object2)
        {
            MainString news= new MainString();
            news.New_string = new char[object1.Length+ object2.Length];
            for (int i = 0; i < object1.Length; i++)
            {
                news.New_string[i] = object1.New_string[i];
            }
            for (int i = 0; i < object2.Length; i++)
            {
                news.New_string[object1.Length+i] = object2.New_string[i];
            }
            return news;
        }

        public static MainString operator +(MainString object1,char [] object2)
        {
            MainString news = new MainString();
            news.new_string = new char[object1.Length + object2.Length];
            for (int i = 0; i < object1.Length; i++)
            {
                news.New_string[i] = object1.New_string[i];
            }
            for (int i = 0; i < object2.Length; i++)
            {
                news.New_string[object1.Length + i] = object2[i];
            }

            return news;
        }

        #endregion
    }
}