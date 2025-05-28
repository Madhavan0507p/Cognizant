import java.lang.reflect.Method;

class ReflectionExample {
    public void greet(String name) {
        System.out.println("Hello, " + name);
    }

    public static void main(String[] args) throws Exception {
        Class<?> cls = Class.forName("ReflectionExample");
        Method[] methods = cls.getDeclaredMethods();

        System.out.println("Methods:");
        for (Method m : methods) {
            System.out.println(m.getName() + " - Parameters: " + m.getParameterCount());
        }

        Object obj = cls.getDeclaredConstructor().newInstance();
        Method greetMethod = cls.getMethod("greet", String.class);
        greetMethod.invoke(obj, "Praveen");
    }
}
