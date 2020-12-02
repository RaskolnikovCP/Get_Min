public int GetMin(int[] arr)
        {
            int min = Int32.MaxValue;

            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                if (min != 0 && arr[i] != 0 && arr[i] <= min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
