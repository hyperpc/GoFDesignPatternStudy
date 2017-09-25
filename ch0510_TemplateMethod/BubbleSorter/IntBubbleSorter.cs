namespace ch0510_TemplateMethod.BubbleSorter
{
    public class IntBubbleSorter : BubbleSorter
    {
        private int[] array = null;
        public int sort(int[] theArray)
        {
            array = theArray;
            length = array.Length;
            return doSort();
        }
        protected override bool outOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }

        protected override void Swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
