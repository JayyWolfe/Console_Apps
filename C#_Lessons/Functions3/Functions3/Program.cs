/*
Name: Jay
Class: Sci 20s
Description:
*/

namespace Functions3
{
    public class functionslesson
    {
        // to declare a function
        // data_type function_name (input_data_type variable_name) 
        static int sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        static void burgerOrder(String order, bool extraCheese = false) //extraCheese is optional because it has a default value.
        {
            if (extraCheese)
            {
                return order + "with extra cheese"
                
                    else
                    {
                    return order + "without extra cheese"

                    }
            }   
        }


        public static void Main()
        {

        }



    }
}
