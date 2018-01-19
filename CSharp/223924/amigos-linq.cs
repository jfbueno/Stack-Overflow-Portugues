static int d(int n) => Enumerable.Range(1, n-1).Where(i => n % i == 0).Sum();   
void Main()
{
    int N = 1500;       
    var q = from e in Enumerable.Range(2, N-1)
            let k = d(d(e))
            let v = d(e)
            where e == k && e > v
            select new {k,v};

    foreach(var a in q) Console.WriteLine(a);
}