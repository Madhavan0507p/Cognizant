import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.*;

class ExecutorCallableExample {
    public static void main(String[] args) throws Exception {
        ExecutorService executor = Executors.newFixedThreadPool(5);
        List<Callable<String>> tasks = new ArrayList<>();

        for (int i = 1; i <= 5; i++) {
            final int id = i;
            tasks.add(() -> {
                Thread.sleep(1000);
                return "Result from task " + id;
            });
        }

        List<Future<String>> results = executor.invokeAll(tasks);

        for (Future<String> future : results) {
            System.out.println(future.get());
        }

        executor.shutdown();
    }
}
