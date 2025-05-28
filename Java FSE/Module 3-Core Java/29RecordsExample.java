import java.util.List;

record Person(String name, int age) {}

class RecordsExample {
    public static void main(String[] args) {
        Person p1 = new Person("Alice", 25);
        Person p2 = new Person("Bob", 30);
        Person p3 = new Person("Charlie", 15);

        System.out.println(p1);
        System.out.println(p2);
        System.out.println(p3);

        List<Person> people = List.of(p1, p2, p3);

        System.out.println("People aged 18 or older:");
        people.stream()
              .filter(person -> person.age() >= 18)
              .forEach(System.out::println);
    }
}
