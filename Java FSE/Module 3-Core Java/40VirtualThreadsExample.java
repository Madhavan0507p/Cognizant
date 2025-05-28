class VirtualThreadsExample {
    public static void main(String[] args) throws InterruptedException {
        Runnable task = () -> System.out.println("Hello from virtual thread: " + Thread.currentThread());

        for (int i = 0; i < 100_000; i++) {
            Thread.startVirtualThread(task);
        }

        // Small sleep to let threads finish printing (not perfect for real app)
        Thread.sleep(2000);
    }
}
