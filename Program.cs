namespace FiveThree {
    class Program {
        static void Main(string[] args) {
            var n = System.Int32.Parse(System.Console.ReadLine());            
            var sa = System.Console.ReadLine().Split(new string[]{"  ", " "}, System.StringSplitOptions.None);
            var a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = System.Int32.Parse(sa[i]);
            }
            if (n > 1) {
                NextPermut(ref a, ref n);
            }
            foreach (var j in a) {
                System.Console.Write(j + " ");
            }
        }

        static void NextPermut(ref int[] a, ref int n) {
            var i = n - 1;
            var isSorted = false;
            while (a[i] <= a[i-1]) {
                --i;
                if (i == 0) {
                    isSorted = true;
                    break;
                }
            }
            var j = n - 1;
            if (!isSorted) {                
                while (a[i-1] >= a[j]) {
                    --j;
                }
                (a[i-1], a[j]) = (a[j], a[i-1]);;
            }
            ++i;
            j = n;
            while (i < j) {
                (a[i-1], a[j-1]) = (a[j-1], a[i-1]);
                ++i;
                --j;
            }
        }
    }
}
