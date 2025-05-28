import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class LambdaExpressions {
    public static void main(String[] args) {
        List<String> names = new ArrayList<>();
        names.add("Praveen");
        names.add("Anita");
        names.add("Zara");
        names.add("Mark");

        Collections.sort(names, (a, b) -> a.compareToIgnoreCase(b));

        System.out.println("Sorted names:");
        names.forEach(System.out::println);
    }
}
