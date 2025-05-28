class MethodOverloading {
    static int add(int a, int b) {
        return a + b;
    }

    static double add(double a, double b) {
        return a + b;
    }

    static int add(int a, int b, int c) {
        return a + b + c;
    }

    public static void main(String[] args) {
        System.out.println("Sum of 2 int: " + add(5, 10));
        System.out.println("Sum of 2 double: " + add(2.5, 3.5));
        System.out.println("Sum of 3 int: " + add(1, 2, 3));
    }
}
