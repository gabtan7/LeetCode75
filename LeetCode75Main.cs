
namespace LeetCode75
{
    public class LeetCode75Main
    {
        static public void Main()
        {

#region  ArrayString
            int arrayStringProbNum = 0;
            switch (arrayStringProbNum)
            {
                case 1:
                    new MergeAlternatelyClass().Main();
                    break;
                case 2:
                    new GcdOfStringsClass().Main();
                    break;
                case 3:
                    new KidsWithCandiesClass().Main();
                    break;
                case 4:
                    new CanPlaceFlowersClass().Main();
                    break;
                case 5:
                    new ReverseVowelsClass().Main();
                    break;
                case 6:
                    new ReverseWordsClass().Main();
                    break;
                case 7:
                    new ProductExceptSelfClass().Main();
                    break;
                case 8:
                    new IncreasingTripletClass().Main();
                    break;
                case 9:
                    new CompressClass().Main();
                    break;
            }
#endregion

#region  TwoPointers
            int twoPointersProbNum = 2;
            switch (twoPointersProbNum)
            {
                case 1:
                    new MoveZeroesClass().Main();
                    break;
                case 2:
                    new IsSubsequenceClass().Main();
                    break;
            }
#endregion
        }
    }
}
