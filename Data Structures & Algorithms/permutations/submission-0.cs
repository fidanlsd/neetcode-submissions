public class Solution
{
    public List<List<int>> Permute(int[] nums)
    {
        var result = new List<List<int>>();
        var permutation = new List<int>();

        Backtrack(nums, permutation, result);

        return result;
    }

    private void Backtrack(
        int[] nums,
        List<int> permutation,
        List<List<int>> result)
    {
        // Собрали перестановку целиком
        if (permutation.Count == nums.Length)
        {
            result.Add(new List<int>(permutation));
            return;
        }

        // Пробуем каждое число
        for (int i = 0; i < nums.Length; i++)
        {
            // Если число уже использовали — пропускаем
            if (permutation.Contains(nums[i]))
                continue;

            // 1. Выбираем число
            permutation.Add(nums[i]);

            // 2. Идём глубже
            Backtrack(nums, permutation, result);

            // 3. Отменяем выбор
            permutation.RemoveAt(permutation.Count - 1);
        }
    }
}
