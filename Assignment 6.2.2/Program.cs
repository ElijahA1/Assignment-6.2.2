namespace Assignment_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 1, 0, -3, 3 };
            int[] array2 = { 1, 2, 3, 4 };

            foreach (int i in ProductCombos(array))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nNext Case:\n");
            foreach (int i in ProductCombos(array2))
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        // Second approach. O(n)
        static int[] ProductCombos(int[] array)
        {
            int[] products = new int[array.Length];
            int[] productsPre = new int[array.Length];
            int[] productsPost = new int[array.Length];

            productsPre[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                productsPre[i] = array[i - 1] * productsPre[i - 1];
                
            }

            productsPost[array.Length -1] = 1;
            for (int i = array.Length - 2; i >= 0; i--)
            {
                productsPost[i] = array[i + 1] * productsPost[i + 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                products[i]= productsPre[i] * productsPost[i];
            }

            return products;
        }

        // First approach with nested loops. O(n^2)
        static int[] productCombos(int[] array)
        {
            int[] products = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                products[i] = 1;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    products[i] *= array[j];
                }
            }
            return products;
        }
    }
}