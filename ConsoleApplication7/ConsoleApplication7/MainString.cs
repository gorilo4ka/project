namespace ConsoleApplication7
{
    public class MainString
    {
        char[] new_string = null;
       public char [] New_string { get { return new_string; }
                                   set { new_string = value; }
                                 }
    static string error = "Ошибка!";
        char[] err = error.ToCharArray();

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
        public MainString(char[] a, int b)
        {
            New_string = a;
            
        }
        public MainString(char[] a, int b, int c)
        {
            New_string = a;
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

    }
}