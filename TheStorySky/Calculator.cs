// You kinda want one class per file

namespace TheStorySky
{
    public class Calculator
    {
        // static modifier, which will come after access modifiers, basically says there will only be one instance of "whatever" in memory. 
        // So this int method is only in one place, on the class, not on every object
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
    }
}