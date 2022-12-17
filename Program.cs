namespace ThreeThree {
    class Program {
        static void Main(string[] args) {
            var n = System.Int32.Parse(System.Console.ReadLine());
            var sa = System.Console.ReadLine().Split();
            var a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = System.Int32.Parse(sa[i]);
            }
            foreach (var j in a) {
                System.Console.Write(j + " ");
            }
        }

        static void NextPermut(int[] a, int n) {

        }
    }
}
