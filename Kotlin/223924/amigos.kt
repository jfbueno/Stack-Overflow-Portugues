fun main(args: Array<String>) {
    val n = 1500
    print((2..n)
          .filter{i -> d(d(i)) == i && i > d(i) }
          .map{"${ it }-${ d(it) }"})
}    

fun d(n: Int) = (1..n-1).filter { n % it == 0 }.sum()