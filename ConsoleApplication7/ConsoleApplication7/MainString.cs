namespace ConsoleApplication7
{
   public class MainString
    {
        public char[] new_string=null;
        static string error = "Ошибка!";
        char[] err = error.ToCharArray();

        public MainString()
        {
        }
        public MainString(char a, int b)
        {
            if (b < 0)
                b = 0;
            new_string = new char[b];
            for (int i = 0; i < b; i++)
            {
                new_string[i] = a;
            }
        }
        public MainString(char[] a, int b)
        {
            new_string = a;
            
        }
        public MainString(char[] a, int b, int c)
        {
            new_string = a;
        }
        public int Length
        {           
            get
            {
                if (new_string == null)
                {
                    return 0;
                }
                return new_string.Length;
            }
        }

        public char Char_index(int a)
        {
            if (a < 0 || a >= new_string.Length)
                return '"';
            return new_string[a];
        }

        public char[] Char_Concat( char [] a)
        {
            char[] new_Concat = new char[new_string.Length+a.Length];           
            for (int i = 0; i < new_string.Length; i++)
            {
                new_Concat[i] = new_string[i];
            }
            for (int j = 0; j < a.Length; j++)
            {
                new_Concat[new_string.Length + j] = a[j];
            }
            
            return new_Concat;
        }

        public MainString Class_Concat(MainString ob)
        {
            MainString ozz = new MainString();
            ozz.new_string = new char[new_string.Length+ob.Length];
            for (int i = 0; i < new_string.Length; i++)
            {
                ozz.new_string[i] = new_string[i];
            }
            for (int j = 0; j < ob.Length; j++)
            {
                ozz.new_string[new_string.Length + j] = ob.new_string[j];
            }
            return  ozz;
        }

    }
}