namespace Arrays
{
    //here we will look abstract view of array and its implementation and operation
    class ArrayOperations
    {
        //initialising an array
        int[] array =  new int[10];




        //array is continuos block of memory
        //array is refrence type in c#

        //operations performed on array
        //1. insertion
        //2. update
        //3. deletion
        //4. transversal

        //cost of each kind of operation
        //1. insertion -> insertion in the end is O(1) but in between is costly o(n)  where n-> number of shift done
        //2. update -> update at perticular location is O(1)
        //3. deletion -> deletion is also ifficient at perticular location O(1)
        //4. tranversal -> traversal is also O(1)


        //Array operation

        //insertion element in the end

        /// <summary>
        /// insertion element in the end
        /// </summary>
        /// <param name="number"></param>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        /// <returns>return the resulted array</returns>
        internal int[] insertAtend(int number, int [] arr,int size)
        {
            arr[size - 1] = number;

            return arr;
        }



        /// <summary>
        /// insertion element in the beggining or inbetween
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="arr"></param>
        /// <param name="position"></param>
        /// <returns>return the resulted array</returns>
        internal int[] insertInbetween(int v1, int[] arr, int position)
        {
            int temp1 = 0,temp2,count = position;

            for (int i = position-1; i < arr.Length-1; i++)
            {
                temp1 = arr[i];

                if (i == position-1)
                {
                    temp1 = v1;
                    temp2 = arr[i];
                    arr[i] = temp1;
                    temp1 = temp2;

                }
                else
                {
                    temp2 = arr[i + 1];
                    arr[i] = temp1;
                    temp1 = temp2;

                }

                count++;
            }

            arr[count-1] = temp1;
            return arr;
        }


        /// <summary>
        /// delete an element in between the array
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="arr"></param>
        /// <param name="position"></param>
        /// <returns>return the last index of modified array</returns>
        internal int deleteInbetween(int v1,int[] arr, int position)
        {
            int count = 0;
            for (int i = position-1; i < arr.Length-1; i++)
            {
               
                    arr[i] = arr[i + 1];
                    count = i;
                
            }
           // arr[count+1] = 0;
            return count+1;
        }


        /// <summary>
        /// return index of element if element found
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        internal int searchElement(int[] arr,int element)
        {
            int position = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==element)
                {
                    position = i;
                    break;
                }
            }
            
            return position;
            
            
        }
    }
}
