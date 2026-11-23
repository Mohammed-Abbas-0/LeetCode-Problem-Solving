
public class ProductOfNumbers {
    private List<int> prefix;

    public ProductOfNumbers() {
        prefix = new List<int> { 1 };
    }

    public void Add(int num) {
        if (num == 0) {
            prefix.Clear();
            prefix.Add(1);
        }
        else {
            prefix.Add(prefix[^1] * num);
        }
    }

    public int GetProduct(int k) {
        if (k >= prefix.Count)
            return 0;

        return prefix[^1] / prefix[prefix.Count - k - 1];
    }
}
