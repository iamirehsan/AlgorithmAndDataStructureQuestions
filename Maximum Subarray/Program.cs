var numbers = new List<int>() { 1, -3, 2, 1, -1, 3, -2 };
var result = MaximumSubarraySum(numbers);

int MaximumSubarraySum(List<int> nums)
{
    int currentSum = 0;
    int globalMax = nums[0];

    foreach (int num in nums)
    {
        currentSum += num;
        if (currentSum > globalMax)
        {
            globalMax = currentSum;
        }
        if (currentSum < 0)
        {
            currentSum = 0;
        }
    }

    return globalMax;
}
