import java.util.HashMap;
import java.util.Scanner;

class HashMapExample {
    public static void main(String[] args) {
        HashMap<Integer, String> studentMap = new HashMap<>();
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter student ID and name (type '0' as ID to stop):");
        while (true) {
            System.out.print("ID: ");
            int id = sc.nextInt();
            sc.nextLine(); // consume newline
            if (id == 0) break;

            System.out.print("Name: ");
            String name = sc.nextLine();
            studentMap.put(id, name);
        }

        System.out.print("Enter an ID to search: ");
        int searchId = sc.nextInt();
        String studentName = studentMap.get(searchId);
        if (studentName != null) {
            System.out.println("Student name: " + studentName);
        } else {
            System.out.println("ID not found.");
        }
    }
}
