class TypeCasting {
    public static void main(String[] args) {
        double myDouble = 9.78;
        int myInt = (int) myDouble;

        System.out.println("Double: " + myDouble);
        System.out.println("Cast to int: " + myInt);

        int number = 100;
        double newDouble = (double) number;

        System.out.println("Int: " + number);
        System.out.println("Cast to double: " + newDouble);
    }
}
