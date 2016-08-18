namespace ConsoleApplication7
{
   public class MainString
    {
        char[] new_string;
        
        public MainString()
        {
        }
        public MainString(char a, int b)
        {
        }
        public MainString(char[] a, int b)
        {
            new_string = a;
            
        }
        public MainString(char[] a, int b, int c)
        {
            new_string = a;
        }
        public int capacity
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

        public char[] Char_Concat(params char [] a)
        {
            char[] new_Concat = new char[a.Length];
            string error = "Ошибка!";
            char[] char_0 = error.ToCharArray();
            if (a.Length == 0)
            {
               return char_0;
            }          
            
            for (int i = 0; i < a.Length; i++)
            {
                new_Concat[i] = a[i];
            }
            
            return new_Concat;
        }
    }
}